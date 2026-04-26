

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
    internal partial interface IDecimalSingleTypedecimal
    {
    }
    
    internal partial class DecimalSingleTypedecimal : IDecimalSingleTypedecimal
    {


#region TestData

        private readonly Decimaldecimal0M[] _testData = new Decimaldecimal0M[]
        {
            new Decimaldecimal0M
{
    Id = 4,
    Value = 0.0702129340450373m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 13,
    Value = 0.927872322450411m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 4,
    Value = 0.349975019596941m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 22,
    Value = 0.907126523790213m,
    ModelInner = null,
    NullableValue = 0.143134904578337m,
},
            new Decimaldecimal0M
{
    Id = 29,
    Value = 0.818272843907014m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 10,
    Value = 0.167508165366423m,
    NullableValue = 0.647213170923046m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 35,
    Value = 0.47230460073711m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 42,
    Value = 0.472644222162149m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 14,
    Value = 0.262247150819082m,
    NullableValue = null,
},
    NullableValue = 0.512699230771191m,
},
            new Decimaldecimal0M
{
    Id = 51,
    Value = 0.781609564039497m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 52,
    Value = 0.616930570960427m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 15,
    Value = 0.635591649526834m,
    NullableValue = null,
},
    NullableValue = 0.998138020963221m,
},
            new Decimaldecimal0M
{
    Id = 61,
    Value = 0.932804657259828m,
    ModelInner = null,
    NullableValue = 0.780238157167004m,
},
            new Decimaldecimal0M
{
    Id = 70,
    Value = 0.876781878502676m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 22,
    Value = 0.89590482383611m,
    NullableValue = 0.28024320046283m,
},
    NullableValue = 0.0432021890076423m,
},
            new Decimaldecimal0M
{
    Id = 76,
    Value = 0.891670305175356m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 82,
    Value = 0.490275146747983m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 23,
    Value = 0.228355292574424m,
    NullableValue = 0.473608138097583m,
},
    NullableValue = 0.926821162549332m,
},
            new Decimaldecimal0M
{
    Id = 83,
    Value = 0.1620401032272m,
    ModelInner = null,
    NullableValue = 0.97901341554195m,
},
            new Decimaldecimal0M
{
    Id = 92,
    Value = 0.537261207769997m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 27,
    Value = 0.932790170476921m,
    NullableValue = null,
},
    NullableValue = 0.847445739755961m,
},
            new Decimaldecimal0M
{
    Id = 100,
    Value = 0.224631401349378m,
    ModelInner = null,
    NullableValue = 0.434185310880612m,
},
            new Decimaldecimal0M
{
    Id = 106,
    Value = 0.407013644205149m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 29,
    Value = 0.0607085411892492m,
    NullableValue = 0.275184664764921m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 115,
    Value = 0.829439275132299m,
    ModelInner = null,
    NullableValue = 0.47514810396336m,
},
            new Decimaldecimal0M
{
    Id = 123,
    Value = 0.323460655637727m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 32,
    Value = 0.21375034743606m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 127,
    Value = 0.59054652746608m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 128,
    Value = 0.362448455806426m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 37,
    Value = 0.171346192411758m,
    NullableValue = 0.600226574812011m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 130,
    Value = 0.989704325441993m,
    ModelInner = null,
    NullableValue = 0.795290875549175m,
},
            new Decimaldecimal0M
{
    Id = 137,
    Value = 0.171260405481188m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 39,
    Value = 0.345795922245119m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 145,
    Value = 0.706063195263756m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 147,
    Value = 0.77987935618391m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 48,
    Value = 0.442097003174774m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 155,
    Value = 0.140100932562959m,
    ModelInner = null,
    NullableValue = 0.374733634421627m,
},
            new Decimaldecimal0M
{
    Id = 164,
    Value = 0.728304687022328m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 51,
    Value = 0.933935299527358m,
    NullableValue = null,
},
    NullableValue = 0.242110022536818m,
},
            new Decimaldecimal0M
{
    Id = 173,
    Value = 0.34970548460568m,
    ModelInner = null,
    NullableValue = 0.278638335792028m,
},
            new Decimaldecimal0M
{
    Id = 180,
    Value = 0.720173865248394m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 57,
    Value = 0.848229887815592m,
    NullableValue = null,
},
    NullableValue = 0.0359935093906762m,
},
            new Decimaldecimal0M
{
    Id = 188,
    Value = 0.115113348084151m,
    ModelInner = null,
    NullableValue = 0.792605741529985m,
},
            new Decimaldecimal0M
{
    Id = 196,
    Value = 0.476470353764928m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 58,
    Value = 0.137549378712897m,
    NullableValue = null,
},
    NullableValue = 0.685469205352277m,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.decimaldecimal0mi(
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
            asPartInterface: typeof(IDecimalSingleTypedecimal)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(5)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(5))
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

                changedRows =  ((IDecimalSingleTypedecimal)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypedecimal)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalSingleTypedecimal)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.decimaldecimal0mi(
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
            asPartInterface: typeof(IDecimalSingleTypedecimal)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)7),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)7, 
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

                changedRows =  ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.decimaldecimal0m(
	id,
    value,
    nullablevalue,
    decimaldecimal0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimaldecimal0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(5)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(5),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "decimaldecimal0mi_id", 
                methodParametrName: "decimaldecimal0mi_id", 
                sqlDbType: (System.Data.SqlDbType)(8),
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

                changedRows =  ((IDecimalSingleTypedecimal)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypedecimal)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IDecimalSingleTypedecimal)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.decimaldecimal0m(
	id,
    value,
    nullablevalue,
    decimaldecimal0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimaldecimal0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Decimal), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)7),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)7,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "decimaldecimal0mi_id", 
                methodParametrName: "decimaldecimal0mi_id", 
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

                changedRows =  ((IDecimalSingleTypedecimal)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypedecimal)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";

                var models = await ((IDecimalSingleTypedecimal)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";

                var models =  ((IDecimalSingleTypedecimal)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Decimaldecimal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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

                var models = await ((IDecimalSingleTypedecimal)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((IDecimalSingleTypedecimal)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalSingleTypedecimal)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDecimalSingleTypedecimal)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Decimaldecimal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypedecimal)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalSingleTypedecimal)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatDecimaldecimal0M.AssertModel(models[0],_testData[6], false);FlatDecimaldecimal0M.AssertModel(models[1],_testData[7], false);FlatDecimaldecimal0M.AssertModel(models[2],_testData[8], false);FlatDecimaldecimal0M.AssertModel(models[3],_testData[9], false);FlatDecimaldecimal0M.AssertModel(models[4],_testData[10], false);FlatDecimaldecimal0M.AssertModel(models[5],_testData[11], false);FlatDecimaldecimal0M.AssertModel(models[6],_testData[12], false);FlatDecimaldecimal0M.AssertModel(models[7],_testData[13], false);FlatDecimaldecimal0M.AssertModel(models[8],_testData[14], false);FlatDecimaldecimal0M.AssertModel(models[9],_testData[15], false);FlatDecimaldecimal0M.AssertModel(models[10],_testData[16], false);FlatDecimaldecimal0M.AssertModel(models[11],_testData[17], false);FlatDecimaldecimal0M.AssertModel(models[12],_testData[18], false);FlatDecimaldecimal0M.AssertModel(models[13],_testData[19], false);FlatDecimaldecimal0M.AssertModel(models[14],_testData[20], false);FlatDecimaldecimal0M.AssertModel(models[15],_testData[21], false);FlatDecimaldecimal0M.AssertModel(models[16],_testData[22], false);FlatDecimaldecimal0M.AssertModel(models[17],_testData[23], false);FlatDecimaldecimal0M.AssertModel(models[18],_testData[24], false);FlatDecimaldecimal0M.AssertModel(models[19],_testData[25], false);FlatDecimaldecimal0M.AssertModel(models[20],_testData[26], false);FlatDecimaldecimal0M.AssertModel(models[21],_testData[27], false);FlatDecimaldecimal0M.AssertModel(models[22],_testData[28], false);FlatDecimaldecimal0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatDecimaldecimal0M.AssertModel(models[0],_testData[11], false);FlatDecimaldecimal0M.AssertModel(models[1],_testData[12], false);FlatDecimaldecimal0M.AssertModel(models[2],_testData[13], false);FlatDecimaldecimal0M.AssertModel(models[3],_testData[14], false);FlatDecimaldecimal0M.AssertModel(models[4],_testData[15], false);FlatDecimaldecimal0M.AssertModel(models[5],_testData[16], false);FlatDecimaldecimal0M.AssertModel(models[6],_testData[17], false);FlatDecimaldecimal0M.AssertModel(models[7],_testData[18], false);FlatDecimaldecimal0M.AssertModel(models[8],_testData[19], false);FlatDecimaldecimal0M.AssertModel(models[9],_testData[20], false);FlatDecimaldecimal0M.AssertModel(models[10],_testData[21], false);FlatDecimaldecimal0M.AssertModel(models[11],_testData[22], false);FlatDecimaldecimal0M.AssertModel(models[12],_testData[23], false);FlatDecimaldecimal0M.AssertModel(models[13],_testData[24], false);FlatDecimaldecimal0M.AssertModel(models[14],_testData[25], false);FlatDecimaldecimal0M.AssertModel(models[15],_testData[26], false);FlatDecimaldecimal0M.AssertModel(models[16],_testData[27], false);FlatDecimaldecimal0M.AssertModel(models[17],_testData[28], false);FlatDecimaldecimal0M.AssertModel(models[18],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatDecimaldecimal0M.AssertModel(models[0],_testData[7], false);FlatDecimaldecimal0M.AssertModel(models[1],_testData[8], false);FlatDecimaldecimal0M.AssertModel(models[2],_testData[9], false);FlatDecimaldecimal0M.AssertModel(models[3],_testData[10], false);FlatDecimaldecimal0M.AssertModel(models[4],_testData[11], false);FlatDecimaldecimal0M.AssertModel(models[5],_testData[12], false);FlatDecimaldecimal0M.AssertModel(models[6],_testData[13], false);FlatDecimaldecimal0M.AssertModel(models[7],_testData[14], false);FlatDecimaldecimal0M.AssertModel(models[8],_testData[15], false);FlatDecimaldecimal0M.AssertModel(models[9],_testData[16], false);FlatDecimaldecimal0M.AssertModel(models[10],_testData[17], false);FlatDecimaldecimal0M.AssertModel(models[11],_testData[18], false);FlatDecimaldecimal0M.AssertModel(models[12],_testData[19], false);FlatDecimaldecimal0M.AssertModel(models[13],_testData[20], false);FlatDecimaldecimal0M.AssertModel(models[14],_testData[21], false);FlatDecimaldecimal0M.AssertModel(models[15],_testData[22], false);FlatDecimaldecimal0M.AssertModel(models[16],_testData[23], false);FlatDecimaldecimal0M.AssertModel(models[17],_testData[24], false);FlatDecimaldecimal0M.AssertModel(models[18],_testData[25], false);FlatDecimaldecimal0M.AssertModel(models[19],_testData[26], false);FlatDecimaldecimal0M.AssertModel(models[20],_testData[27], false);FlatDecimaldecimal0M.AssertModel(models[21],_testData[28], false);FlatDecimaldecimal0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatDecimaldecimal0M.AssertModel(models[0],_testData[24], false);FlatDecimaldecimal0M.AssertModel(models[1],_testData[25], false);FlatDecimaldecimal0M.AssertModel(models[2],_testData[26], false);FlatDecimaldecimal0M.AssertModel(models[3],_testData[27], false);FlatDecimaldecimal0M.AssertModel(models[4],_testData[28], false);FlatDecimaldecimal0M.AssertModel(models[5],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Decimaldecimal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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

                var models = await ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
Decimaldecimal0M.AssertModel(models[0],_testData[26], false);Decimaldecimal0M.AssertModel(models[1],_testData[27], false);Decimaldecimal0M.AssertModel(models[2],_testData[28], false);Decimaldecimal0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
Decimaldecimal0M.AssertModel(models[0],_testData[9], false);Decimaldecimal0M.AssertModel(models[1],_testData[10], false);Decimaldecimal0M.AssertModel(models[2],_testData[11], false);Decimaldecimal0M.AssertModel(models[3],_testData[12], false);Decimaldecimal0M.AssertModel(models[4],_testData[13], false);Decimaldecimal0M.AssertModel(models[5],_testData[14], false);Decimaldecimal0M.AssertModel(models[6],_testData[15], false);Decimaldecimal0M.AssertModel(models[7],_testData[16], false);Decimaldecimal0M.AssertModel(models[8],_testData[17], false);Decimaldecimal0M.AssertModel(models[9],_testData[18], false);Decimaldecimal0M.AssertModel(models[10],_testData[19], false);Decimaldecimal0M.AssertModel(models[11],_testData[20], false);Decimaldecimal0M.AssertModel(models[12],_testData[21], false);Decimaldecimal0M.AssertModel(models[13],_testData[22], false);Decimaldecimal0M.AssertModel(models[14],_testData[23], false);Decimaldecimal0M.AssertModel(models[15],_testData[24], false);Decimaldecimal0M.AssertModel(models[16],_testData[25], false);Decimaldecimal0M.AssertModel(models[17],_testData[26], false);Decimaldecimal0M.AssertModel(models[18],_testData[27], false);Decimaldecimal0M.AssertModel(models[19],_testData[28], false);Decimaldecimal0M.AssertModel(models[20],_testData[29], false);
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

                var models =  ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
Decimaldecimal0M.AssertModel(models[0],_testData[23], false);Decimaldecimal0M.AssertModel(models[1],_testData[24], false);Decimaldecimal0M.AssertModel(models[2],_testData[25], false);Decimaldecimal0M.AssertModel(models[3],_testData[26], false);Decimaldecimal0M.AssertModel(models[4],_testData[27], false);Decimaldecimal0M.AssertModel(models[5],_testData[28], false);Decimaldecimal0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
Decimaldecimal0M.AssertModel(models[0],_testData[10], false);Decimaldecimal0M.AssertModel(models[1],_testData[11], false);Decimaldecimal0M.AssertModel(models[2],_testData[12], false);Decimaldecimal0M.AssertModel(models[3],_testData[13], false);Decimaldecimal0M.AssertModel(models[4],_testData[14], false);Decimaldecimal0M.AssertModel(models[5],_testData[15], false);Decimaldecimal0M.AssertModel(models[6],_testData[16], false);Decimaldecimal0M.AssertModel(models[7],_testData[17], false);Decimaldecimal0M.AssertModel(models[8],_testData[18], false);Decimaldecimal0M.AssertModel(models[9],_testData[19], false);Decimaldecimal0M.AssertModel(models[10],_testData[20], false);Decimaldecimal0M.AssertModel(models[11],_testData[21], false);Decimaldecimal0M.AssertModel(models[12],_testData[22], false);Decimaldecimal0M.AssertModel(models[13],_testData[23], false);Decimaldecimal0M.AssertModel(models[14],_testData[24], false);Decimaldecimal0M.AssertModel(models[15],_testData[25], false);Decimaldecimal0M.AssertModel(models[16],_testData[26], false);Decimaldecimal0M.AssertModel(models[17],_testData[27], false);Decimaldecimal0M.AssertModel(models[18],_testData[28], false);Decimaldecimal0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 130, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatDecimaldecimal0M.AssertModel(models[0],_testData[21], false);FlatDecimaldecimal0M.AssertModel(models[1],_testData[22], false);FlatDecimaldecimal0M.AssertModel(models[2],_testData[23], false);FlatDecimaldecimal0M.AssertModel(models[3],_testData[24], false);FlatDecimaldecimal0M.AssertModel(models[4],_testData[25], false);FlatDecimaldecimal0M.AssertModel(models[5],_testData[26], false);FlatDecimaldecimal0M.AssertModel(models[6],_testData[27], false);FlatDecimaldecimal0M.AssertModel(models[7],_testData[28], false);FlatDecimaldecimal0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatDecimaldecimal0M.AssertModel(models[0],_testData[20], false);FlatDecimaldecimal0M.AssertModel(models[1],_testData[21], false);FlatDecimaldecimal0M.AssertModel(models[2],_testData[22], false);FlatDecimaldecimal0M.AssertModel(models[3],_testData[23], false);FlatDecimaldecimal0M.AssertModel(models[4],_testData[24], false);FlatDecimaldecimal0M.AssertModel(models[5],_testData[25], false);FlatDecimaldecimal0M.AssertModel(models[6],_testData[26], false);FlatDecimaldecimal0M.AssertModel(models[7],_testData[27], false);FlatDecimaldecimal0M.AssertModel(models[8],_testData[28], false);FlatDecimaldecimal0M.AssertModel(models[9],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatch(connection, 137, query1, 155, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatDecimaldecimal0M.AssertModel(models[0],_testData[22], false);FlatDecimaldecimal0M.AssertModel(models[1],_testData[23], false);FlatDecimaldecimal0M.AssertModel(models[2],_testData[24], false);FlatDecimaldecimal0M.AssertModel(models[3],_testData[25], false);FlatDecimaldecimal0M.AssertModel(models[4],_testData[26], false);FlatDecimaldecimal0M.AssertModel(models[5],_testData[27], false);FlatDecimaldecimal0M.AssertModel(models[6],_testData[28], false);FlatDecimaldecimal0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatDecimaldecimal0M.AssertModel(models[0],_testData[25], false);FlatDecimaldecimal0M.AssertModel(models[1],_testData[26], false);FlatDecimaldecimal0M.AssertModel(models[2],_testData[27], false);FlatDecimaldecimal0M.AssertModel(models[3],_testData[28], false);FlatDecimaldecimal0M.AssertModel(models[4],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Decimaldecimal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
                var models = await ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelBatchAsync(connection, 137, 76))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
Decimaldecimal0M.AssertModel(models[0],_testData[22], false);Decimaldecimal0M.AssertModel(models[1],_testData[23], false);Decimaldecimal0M.AssertModel(models[2],_testData[24], false);Decimaldecimal0M.AssertModel(models[3],_testData[25], false);Decimaldecimal0M.AssertModel(models[4],_testData[26], false);Decimaldecimal0M.AssertModel(models[5],_testData[27], false);Decimaldecimal0M.AssertModel(models[6],_testData[28], false);Decimaldecimal0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
Decimaldecimal0M.AssertModel(models[0],_testData[11], false);Decimaldecimal0M.AssertModel(models[1],_testData[12], false);Decimaldecimal0M.AssertModel(models[2],_testData[13], false);Decimaldecimal0M.AssertModel(models[3],_testData[14], false);Decimaldecimal0M.AssertModel(models[4],_testData[15], false);Decimaldecimal0M.AssertModel(models[5],_testData[16], false);Decimaldecimal0M.AssertModel(models[6],_testData[17], false);Decimaldecimal0M.AssertModel(models[7],_testData[18], false);Decimaldecimal0M.AssertModel(models[8],_testData[19], false);Decimaldecimal0M.AssertModel(models[9],_testData[20], false);Decimaldecimal0M.AssertModel(models[10],_testData[21], false);Decimaldecimal0M.AssertModel(models[11],_testData[22], false);Decimaldecimal0M.AssertModel(models[12],_testData[23], false);Decimaldecimal0M.AssertModel(models[13],_testData[24], false);Decimaldecimal0M.AssertModel(models[14],_testData[25], false);Decimaldecimal0M.AssertModel(models[15],_testData[26], false);Decimaldecimal0M.AssertModel(models[16],_testData[27], false);Decimaldecimal0M.AssertModel(models[17],_testData[28], false);Decimaldecimal0M.AssertModel(models[18],_testData[29], false);
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
                var models =  ((IDecimalSingleTypedecimal)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelBatch(connection, 106, 173))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
Decimaldecimal0M.AssertModel(models[0],_testData[16], false);Decimaldecimal0M.AssertModel(models[1],_testData[17], false);Decimaldecimal0M.AssertModel(models[2],_testData[18], false);Decimaldecimal0M.AssertModel(models[3],_testData[19], false);Decimaldecimal0M.AssertModel(models[4],_testData[20], false);Decimaldecimal0M.AssertModel(models[5],_testData[21], false);Decimaldecimal0M.AssertModel(models[6],_testData[22], false);Decimaldecimal0M.AssertModel(models[7],_testData[23], false);Decimaldecimal0M.AssertModel(models[8],_testData[24], false);Decimaldecimal0M.AssertModel(models[9],_testData[25], false);Decimaldecimal0M.AssertModel(models[10],_testData[26], false);Decimaldecimal0M.AssertModel(models[11],_testData[27], false);Decimaldecimal0M.AssertModel(models[12],_testData[28], false);Decimaldecimal0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
Decimaldecimal0M.AssertModel(models[0],_testData[27], false);Decimaldecimal0M.AssertModel(models[1],_testData[28], false);Decimaldecimal0M.AssertModel(models[2],_testData[29], false);
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
                await using var cmd = await ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 127);
                var models = await ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
Decimaldecimal0M.AssertModel(models[0],_testData[19], false);Decimaldecimal0M.AssertModel(models[1],_testData[20], false);Decimaldecimal0M.AssertModel(models[2],_testData[21], false);Decimaldecimal0M.AssertModel(models[3],_testData[22], false);Decimaldecimal0M.AssertModel(models[4],_testData[23], false);Decimaldecimal0M.AssertModel(models[5],_testData[24], false);Decimaldecimal0M.AssertModel(models[6],_testData[25], false);Decimaldecimal0M.AssertModel(models[7],_testData[26], false);Decimaldecimal0M.AssertModel(models[8],_testData[27], false);Decimaldecimal0M.AssertModel(models[9],_testData[28], false);Decimaldecimal0M.AssertModel(models[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models =  ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
Decimaldecimal0M.AssertModel(models[0],_testData[8], false);Decimaldecimal0M.AssertModel(models[1],_testData[9], false);Decimaldecimal0M.AssertModel(models[2],_testData[10], false);Decimaldecimal0M.AssertModel(models[3],_testData[11], false);Decimaldecimal0M.AssertModel(models[4],_testData[12], false);Decimaldecimal0M.AssertModel(models[5],_testData[13], false);Decimaldecimal0M.AssertModel(models[6],_testData[14], false);Decimaldecimal0M.AssertModel(models[7],_testData[15], false);Decimaldecimal0M.AssertModel(models[8],_testData[16], false);Decimaldecimal0M.AssertModel(models[9],_testData[17], false);Decimaldecimal0M.AssertModel(models[10],_testData[18], false);Decimaldecimal0M.AssertModel(models[11],_testData[19], false);Decimaldecimal0M.AssertModel(models[12],_testData[20], false);Decimaldecimal0M.AssertModel(models[13],_testData[21], false);Decimaldecimal0M.AssertModel(models[14],_testData[22], false);Decimaldecimal0M.AssertModel(models[15],_testData[23], false);Decimaldecimal0M.AssertModel(models[16],_testData[24], false);Decimaldecimal0M.AssertModel(models[17],_testData[25], false);Decimaldecimal0M.AssertModel(models[18],_testData[26], false);Decimaldecimal0M.AssertModel(models[19],_testData[27], false);Decimaldecimal0M.AssertModel(models[20],_testData[28], false);Decimaldecimal0M.AssertModel(models[21],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
LEFT JOIN dbo.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
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
            asPartInterface: typeof(IDecimalSingleTypedecimal))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0702129340450373m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.927872322450411m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.349975019596941m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.907126523790213m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.143134904578337m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.818272843907014m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.167508165366423m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.647213170923046m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.47230460073711m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.472644222162149m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.262247150819082m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.512699230771191m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.781609564039497m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.616930570960427m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.635591649526834m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.998138020963221m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.932804657259828m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.780238157167004m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.876781878502676m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.89590482383611m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.28024320046283m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0432021890076423m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.891670305175356m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.490275146747983m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.228355292574424m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.473608138097583m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.926821162549332m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.1620401032272m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.97901341554195m)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.537261207769997m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.932790170476921m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.847445739755961m)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.224631401349378m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.434185310880612m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.407013644205149m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0607085411892492m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.275184664764921m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.829439275132299m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.47514810396336m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.323460655637727m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.21375034743606m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.59054652746608m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.362448455806426m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.171346192411758m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.600226574812011m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.989704325441993m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.795290875549175m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.171260405481188m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.345795922245119m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.706063195263756m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.77987935618391m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.442097003174774m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.140100932562959m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.374733634421627m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.728304687022328m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.933935299527358m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.242110022536818m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.34970548460568m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.278638335792028m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.720173865248394m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.848229887815592m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0359935093906762m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.115113348084151m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.792605741529985m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((196)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.476470353764928m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.137549378712897m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.685469205352277m)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0702129340450373m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.927872322450411m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.349975019596941m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.907126523790213m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.143134904578337m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.818272843907014m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.167508165366423m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.647213170923046m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.47230460073711m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.472644222162149m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.262247150819082m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.512699230771191m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.781609564039497m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.616930570960427m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.635591649526834m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.998138020963221m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.932804657259828m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.780238157167004m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.876781878502676m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.89590482383611m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.28024320046283m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0432021890076423m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.891670305175356m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.490275146747983m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.228355292574424m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.473608138097583m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.926821162549332m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.1620401032272m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.97901341554195m)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.537261207769997m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.932790170476921m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.847445739755961m)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.224631401349378m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.434185310880612m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.407013644205149m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0607085411892492m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.275184664764921m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.829439275132299m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.47514810396336m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.323460655637727m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.21375034743606m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.59054652746608m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.362448455806426m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.171346192411758m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.600226574812011m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.989704325441993m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.795290875549175m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.171260405481188m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.345795922245119m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.706063195263756m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.77987935618391m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.442097003174774m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.140100932562959m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.374733634421627m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.728304687022328m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.933935299527358m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.242110022536818m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.34970548460568m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.278638335792028m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.720173865248394m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.848229887815592m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0359935093906762m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.115113348084151m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.792605741529985m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((196)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.476470353764928m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.137549378712897m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.685469205352277m)));

            }
        }

#endregion

    }
}

