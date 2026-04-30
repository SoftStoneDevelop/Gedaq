

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
    Id = 8,
    Value = 0.629155273246745m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 12,
    Value = 0.523721273616059m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 4,
    Value = 0.119397403162743m,
    NullableValue = null,
},
    NullableValue = 0.0281073693942033m,
},
            new Decimaldecimal0M
{
    Id = 17,
    Value = 0.00286505314774066m,
    ModelInner = null,
    NullableValue = 0.807485805233389m,
},
            new Decimaldecimal0M
{
    Id = 22,
    Value = 0.50357977600089m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 8,
    Value = 0.867686495009926m,
    NullableValue = null,
},
    NullableValue = 0.266283904454928m,
},
            new Decimaldecimal0M
{
    Id = 29,
    Value = 0.312027138578816m,
    ModelInner = null,
    NullableValue = 0.928045117725331m,
},
            new Decimaldecimal0M
{
    Id = 37,
    Value = 0.896759003628747m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 9,
    Value = 0.579102210157939m,
    NullableValue = 0.751193368651716m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 38,
    Value = 0.193844016193489m,
    ModelInner = null,
    NullableValue = 0.705249699018068m,
},
            new Decimaldecimal0M
{
    Id = 40,
    Value = 0.0826338252432168m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 17,
    Value = 0.865907581675948m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 48,
    Value = 0.243634961239698m,
    ModelInner = null,
    NullableValue = 0.159742160348672m,
},
            new Decimaldecimal0M
{
    Id = 57,
    Value = 0.472161076159013m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 22,
    Value = 0.287547561181024m,
    NullableValue = 0.14286915407563m,
},
    NullableValue = 0.423584879202717m,
},
            new Decimaldecimal0M
{
    Id = 63,
    Value = 0.520749502459117m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 69,
    Value = 0.365687020440572m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 31,
    Value = 0.54887939654818m,
    NullableValue = null,
},
    NullableValue = 0.795107099229338m,
},
            new Decimaldecimal0M
{
    Id = 77,
    Value = 0.467097953560144m,
    ModelInner = null,
    NullableValue = 0.190751424978785m,
},
            new Decimaldecimal0M
{
    Id = 84,
    Value = 0.53519839459269m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 36,
    Value = 0.516852806132051m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 89,
    Value = 0.585687790980598m,
    ModelInner = null,
    NullableValue = 0.246765525777749m,
},
            new Decimaldecimal0M
{
    Id = 95,
    Value = 0.13810208321262m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 37,
    Value = 0.570354699546195m,
    NullableValue = 0.458010097480724m,
},
    NullableValue = 0.038988888902157m,
},
            new Decimaldecimal0M
{
    Id = 98,
    Value = 0.540787274623204m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 106,
    Value = 0.236929997888491m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 45,
    Value = 0.636695174239452m,
    NullableValue = null,
},
    NullableValue = 0.129339694654901m,
},
            new Decimaldecimal0M
{
    Id = 112,
    Value = 0.717887946566725m,
    ModelInner = null,
    NullableValue = 0.46986350030308m,
},
            new Decimaldecimal0M
{
    Id = 119,
    Value = 0.021141990813345m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 48,
    Value = 0.377559035095071m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 126,
    Value = 0.568594950887742m,
    ModelInner = null,
    NullableValue = 0.64059626131228m,
},
            new Decimaldecimal0M
{
    Id = 129,
    Value = 0.182297743453076m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 51,
    Value = 0.100763134594214m,
    NullableValue = 0.515425579584606m,
},
    NullableValue = 0.42655780846302m,
},
            new Decimaldecimal0M
{
    Id = 131,
    Value = 0.499674467664003m,
    ModelInner = null,
    NullableValue = 0.323089747071055m,
},
            new Decimaldecimal0M
{
    Id = 133,
    Value = 0.181299005292238m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 57,
    Value = 0.357097175649082m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 136,
    Value = 0.598139634660533m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 144,
    Value = 0.158219215802901m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 63,
    Value = 0.444899242525883m,
    NullableValue = null,
},
    NullableValue = 0.100145945284271m,
},
            new Decimaldecimal0M
{
    Id = 151,
    Value = 0.976792442467531m,
    ModelInner = null,
    NullableValue = 0.00508724765383295m,
},
            new Decimaldecimal0M
{
    Id = 157,
    Value = 0.672239925470517m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 72,
    Value = 0.727981825026589m,
    NullableValue = null,
},
    NullableValue = 0.587695193266599m,
},
            new Decimaldecimal0M
{
    Id = 160,
    Value = 0.38462578749089m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 168,
    Value = 0.445584573309388m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 77,
    Value = 0.686270096038545m,
    NullableValue = 0.911154310069083m,
},
    NullableValue = null,
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
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(5)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(5))
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
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(5)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(5),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "decimaldecimal0mi_id", 
                methodParametrName: "decimaldecimal0mi_id", 
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimal0M), typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                await((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                ((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IDecimalSingleTypedecimal)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IDecimalSingleTypedecimal)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = await((IDecimalSingleTypedecimal)this).SelectModelDynParAsync(connection, [parametr1]);
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
                var models = ((IDecimalSingleTypedecimal)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimal0M), typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                await((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                ((IDecimalSingleTypedecimal)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM dbo.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypedecimal)this).DynQuerySelectModelAsync(connection,  query, 0);
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
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypedecimal)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
                var models = await((IDecimalSingleTypedecimal)this).SelectModelAsync(connection, 0);
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
                var models = ((IDecimalSingleTypedecimal)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimal0M), typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                await((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM dbo.decimaldecimal0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
FROM dbo.decimaldecimal0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.decimaldecimal0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[23],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[24],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[25],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 136;
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.decimaldecimal0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 12;
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[25],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((IDecimalSingleTypedecimal)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Decimaldecimal0M.AssertModel(models[0],_testData[11], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[12], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Decimaldecimal0M.AssertModel(models[0],_testData[1], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[2], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[3], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[4], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[5], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[6], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[7], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[8], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[9], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[10], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[11], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[12], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[19],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[20],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[21],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[22],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[23],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[24],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[25],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[26],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[27],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[28],_testData[29], false);
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
                var models = ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Decimaldecimal0M.AssertModel(models[0],_testData[2], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[3], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[4], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[5], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[6], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[7], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[8], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[9], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[10], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[11], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[12], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[19],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[20],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[21],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[22],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[23],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[24],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[25],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[26],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Decimaldecimal0M.AssertModel(models[0],_testData[11], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[12], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimal0M), typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                await((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 84, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 84, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 12, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 29, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 77, query1, 95, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 112, query1, 106, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.decimaldecimal0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 157, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[29], false);
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
FROM dbo.decimaldecimal0m m
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
FROM dbo.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatch(connection, 38, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[23],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDecimalSingleTypedecimal)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatchAsync(connection, 77, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Decimaldecimal0M.AssertModel(models[0],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Decimaldecimal0M.AssertModel(models[0],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[29], false);
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
                var models = ((IDecimalSingleTypedecimal)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatch(connection, 157, 133))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Decimaldecimal0M.AssertModel(models[0],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Decimaldecimal0M.AssertModel(models[0],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[29], false);
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
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models = await ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
Decimaldecimal0M.AssertModel(models[0],_testData[12], false);Decimaldecimal0M.AssertModel(models[1],_testData[13], false);Decimaldecimal0M.AssertModel(models[2],_testData[14], false);Decimaldecimal0M.AssertModel(models[3],_testData[15], false);Decimaldecimal0M.AssertModel(models[4],_testData[16], false);Decimaldecimal0M.AssertModel(models[5],_testData[17], false);Decimaldecimal0M.AssertModel(models[6],_testData[18], false);Decimaldecimal0M.AssertModel(models[7],_testData[19], false);Decimaldecimal0M.AssertModel(models[8],_testData[20], false);Decimaldecimal0M.AssertModel(models[9],_testData[21], false);Decimaldecimal0M.AssertModel(models[10],_testData[22], false);Decimaldecimal0M.AssertModel(models[11],_testData[23], false);Decimaldecimal0M.AssertModel(models[12],_testData[24], false);Decimaldecimal0M.AssertModel(models[13],_testData[25], false);Decimaldecimal0M.AssertModel(models[14],_testData[26], false);Decimaldecimal0M.AssertModel(models[15],_testData[27], false);Decimaldecimal0M.AssertModel(models[16],_testData[28], false);Decimaldecimal0M.AssertModel(models[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 17);
                var models =  ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
Decimaldecimal0M.AssertModel(models[0],_testData[3], false);Decimaldecimal0M.AssertModel(models[1],_testData[4], false);Decimaldecimal0M.AssertModel(models[2],_testData[5], false);Decimaldecimal0M.AssertModel(models[3],_testData[6], false);Decimaldecimal0M.AssertModel(models[4],_testData[7], false);Decimaldecimal0M.AssertModel(models[5],_testData[8], false);Decimaldecimal0M.AssertModel(models[6],_testData[9], false);Decimaldecimal0M.AssertModel(models[7],_testData[10], false);Decimaldecimal0M.AssertModel(models[8],_testData[11], false);Decimaldecimal0M.AssertModel(models[9],_testData[12], false);Decimaldecimal0M.AssertModel(models[10],_testData[13], false);Decimaldecimal0M.AssertModel(models[11],_testData[14], false);Decimaldecimal0M.AssertModel(models[12],_testData[15], false);Decimaldecimal0M.AssertModel(models[13],_testData[16], false);Decimaldecimal0M.AssertModel(models[14],_testData[17], false);Decimaldecimal0M.AssertModel(models[15],_testData[18], false);Decimaldecimal0M.AssertModel(models[16],_testData[19], false);Decimaldecimal0M.AssertModel(models[17],_testData[20], false);Decimaldecimal0M.AssertModel(models[18],_testData[21], false);Decimaldecimal0M.AssertModel(models[19],_testData[22], false);Decimaldecimal0M.AssertModel(models[20],_testData[23], false);Decimaldecimal0M.AssertModel(models[21],_testData[24], false);Decimaldecimal0M.AssertModel(models[22],_testData[25], false);Decimaldecimal0M.AssertModel(models[23],_testData[26], false);Decimaldecimal0M.AssertModel(models[24],_testData[27], false);Decimaldecimal0M.AssertModel(models[25],_testData[28], false);Decimaldecimal0M.AssertModel(models[26],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.629155273246745m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.523721273616059m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.119397403162743m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0281073693942033m)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00286505314774066m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.807485805233389m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.50357977600089m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.867686495009926m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.266283904454928m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.312027138578816m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.928045117725331m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.896759003628747m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.579102210157939m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.751193368651716m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.193844016193489m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.705249699018068m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0826338252432168m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.865907581675948m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.243634961239698m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.159742160348672m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.472161076159013m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.287547561181024m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.14286915407563m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.423584879202717m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.520749502459117m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.365687020440572m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.54887939654818m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.795107099229338m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.467097953560144m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.190751424978785m)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.53519839459269m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.516852806132051m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.585687790980598m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.246765525777749m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.13810208321262m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.570354699546195m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.458010097480724m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.038988888902157m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.540787274623204m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.236929997888491m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.636695174239452m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.129339694654901m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.717887946566725m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.46986350030308m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.021141990813345m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.377559035095071m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.568594950887742m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.64059626131228m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.182297743453076m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.100763134594214m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.515425579584606m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.42655780846302m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.499674467664003m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.323089747071055m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.181299005292238m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.357097175649082m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.598139634660533m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.158219215802901m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.444899242525883m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.100145945284271m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.976792442467531m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.00508724765383295m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.672239925470517m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.727981825026589m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.587695193266599m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.38462578749089m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.445584573309388m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.686270096038545m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.911154310069083m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.629155273246745m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.523721273616059m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.119397403162743m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0281073693942033m)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00286505314774066m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.807485805233389m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.50357977600089m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.867686495009926m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.266283904454928m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.312027138578816m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.928045117725331m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.896759003628747m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.579102210157939m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.751193368651716m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.193844016193489m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.705249699018068m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0826338252432168m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.865907581675948m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.243634961239698m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.159742160348672m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.472161076159013m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.287547561181024m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.14286915407563m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.423584879202717m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.520749502459117m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.365687020440572m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.54887939654818m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.795107099229338m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.467097953560144m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.190751424978785m)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.53519839459269m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.516852806132051m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.585687790980598m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.246765525777749m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.13810208321262m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.570354699546195m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.458010097480724m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.038988888902157m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.540787274623204m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.236929997888491m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.636695174239452m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.129339694654901m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.717887946566725m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.46986350030308m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.021141990813345m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.377559035095071m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.568594950887742m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.64059626131228m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.182297743453076m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.100763134594214m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.515425579584606m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.42655780846302m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.499674467664003m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.323089747071055m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.181299005292238m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.357097175649082m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.598139634660533m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.158219215802901m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.444899242525883m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.100145945284271m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.976792442467531m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.00508724765383295m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.672239925470517m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.727981825026589m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.587695193266599m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.38462578749089m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.445584573309388m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.686270096038545m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.911154310069083m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

