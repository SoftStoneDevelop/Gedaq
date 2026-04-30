

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
    Id = 3,
    Value = 0.831804834541055m,
    ModelInner = null,
    NullableValue = 0.769710517846559m,
},
            new Decimaldecimal0M
{
    Id = 5,
    Value = 0.216512053519512m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 4,
    Value = 0.474929643407804m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 13,
    Value = 0.353903720971724m,
    ModelInner = null,
    NullableValue = 0.701063955659897m,
},
            new Decimaldecimal0M
{
    Id = 14,
    Value = 0.086474835725572m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 5,
    Value = 0.763629484774358m,
    NullableValue = 0.131127556003932m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 21,
    Value = 0.857323852646455m,
    ModelInner = null,
    NullableValue = 0.0695112880804502m,
},
            new Decimaldecimal0M
{
    Id = 28,
    Value = 0.0527899024462735m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 10,
    Value = 0.829575530297281m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 36,
    Value = 0.11125811906807m,
    ModelInner = null,
    NullableValue = 0.95677744879606m,
},
            new Decimaldecimal0M
{
    Id = 45,
    Value = 0.82986197945742m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 18,
    Value = 0.645883869135037m,
    NullableValue = 0.156492045746368m,
},
    NullableValue = 0.841224451982874m,
},
            new Decimaldecimal0M
{
    Id = 51,
    Value = 0.72820199434384m,
    ModelInner = null,
    NullableValue = 0.134488491798557m,
},
            new Decimaldecimal0M
{
    Id = 55,
    Value = 0.869770546438297m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 26,
    Value = 0.107517130814055m,
    NullableValue = null,
},
    NullableValue = 0.173272304108692m,
},
            new Decimaldecimal0M
{
    Id = 59,
    Value = 0.673963594181798m,
    ModelInner = null,
    NullableValue = 0.202369359346418m,
},
            new Decimaldecimal0M
{
    Id = 62,
    Value = 0.57818528570657m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 32,
    Value = 0.794320940767732m,
    NullableValue = 0.672932939834894m,
},
    NullableValue = 0.203979473397618m,
},
            new Decimaldecimal0M
{
    Id = 70,
    Value = 0.562070690675715m,
    ModelInner = null,
    NullableValue = 0.363532778261739m,
},
            new Decimaldecimal0M
{
    Id = 79,
    Value = 0.443237082193801m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 39,
    Value = 0.676934962991946m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 85,
    Value = 0.200030355256658m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 94,
    Value = 0.801809926907025m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 44,
    Value = 0.582584102549199m,
    NullableValue = 0.630141014691936m,
},
    NullableValue = 0.376147769659632m,
},
            new Decimaldecimal0M
{
    Id = 101,
    Value = 0.272746932122193m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 108,
    Value = 0.0872839651589286m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 50,
    Value = 0.627607525716389m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 110,
    Value = 0.778082815057413m,
    ModelInner = null,
    NullableValue = 0.140314729175143m,
},
            new Decimaldecimal0M
{
    Id = 119,
    Value = 0.71942392282464m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 52,
    Value = 0.979304796415299m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 121,
    Value = 0.354916829828411m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 126,
    Value = 0.992670699071982m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 57,
    Value = 0.441882538732819m,
    NullableValue = 0.718990821363055m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 135,
    Value = 0.253593284236444m,
    ModelInner = null,
    NullableValue = 0.128181261259337m,
},
            new Decimaldecimal0M
{
    Id = 140,
    Value = 0.959902735001532m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 59,
    Value = 0.365976747280594m,
    NullableValue = 0.55741881672777m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 148,
    Value = 0.813588168730402m,
    ModelInner = null,
    NullableValue = 0.04973307982887m,
},
            new Decimaldecimal0M
{
    Id = 156,
    Value = 0.163997993805723m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 65,
    Value = 0.382118527520604m,
    NullableValue = 0.463354762828596m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 164,
    Value = 0.531400915496271m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 169,
    Value = 0.207645599909728m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 70,
    Value = 0.884105246974086m,
    NullableValue = 0.732573774445965m,
},
    NullableValue = 0.686476931716973m,
},
            new Decimaldecimal0M
{
    Id = 177,
    Value = 0.0737794976243316m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 183,
    Value = 0.608574436913296m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 73,
    Value = 0.199920666558033m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 187,
    Value = 0.797868824720177m,
    ModelInner = null,
    NullableValue = 0.948545671261524m,
},
            new Decimaldecimal0M
{
    Id = 188,
    Value = 0.624733759258318m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 81,
    Value = 0.291126273799135m,
    NullableValue = null,
},
    NullableValue = 0.202339054910871m,
},
            new Decimaldecimal0M
{
    Id = 190,
    Value = 0.0820291878051988m,
    ModelInner = null,
    NullableValue = 0.141588376065254m,
},
            new Decimaldecimal0M
{
    Id = 198,
    Value = 0.876942742993138m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 89,
    Value = 0.457081717832899m,
    NullableValue = 0.0662214835643116m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 199,
    Value = 0.657159778110151m,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.decimaldecimal0mi(
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
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(0)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(0))]
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
INSERT INTO gedaqtests.decimaldecimal0mi(
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

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.decimaldecimal0m(
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
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Decimal), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(0)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(0),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "decimaldecimal0mi_id", 
                methodParametrName: "decimaldecimal0mi_id", 
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
INSERT INTO gedaqtests.decimaldecimal0m(
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
                parametrName: "decimaldecimal0mi_id", 
                methodParametrName: "decimaldecimal0mi_id", 
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

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypedecimal)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimal0M), typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM gedaqtests.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                await((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM gedaqtests.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                ((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM gedaqtests.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IDecimalSingleTypedecimal)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM gedaqtests.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IDecimalSingleTypedecimal)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.decimaldecimal0m m
LEFT JOIN gedaqtests.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Decimaldecimal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
                var models = await((IDecimalSingleTypedecimal)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IDecimalSingleTypedecimal)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Decimaldecimal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimal0M), typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM gedaqtests.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                await((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM gedaqtests.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                ((IDecimalSingleTypedecimal)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
FROM gedaqtests.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypedecimal)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM gedaqtests.decimaldecimal0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypedecimal)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.decimaldecimal0m m
LEFT JOIN gedaqtests.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Decimaldecimal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypedecimal)),
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
                var models = await((IDecimalSingleTypedecimal)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM gedaqtests.decimaldecimal0m m
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
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
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
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
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM gedaqtests.decimaldecimal0m m
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
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
                        FlatDecimaldecimal0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM gedaqtests.decimaldecimal0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 187;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[23],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[24],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[25],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[26],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[27],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM gedaqtests.decimaldecimal0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM gedaqtests.decimaldecimal0m m
LEFT JOIN gedaqtests.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

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
                        Decimaldecimal0M.AssertModel(models[29],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[30],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[31],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[32],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Decimaldecimal0M.AssertModel(models[0],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 183;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Decimaldecimal0M.AssertModel(models[0],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Decimaldecimal0M.AssertModel(models[0],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[34], false);
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
            dbType: (System.Data.DbType)(11))]
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                await((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 55, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 62, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimal0M>();
                var models2 = new List<FlatDecimaldecimal0M>();
                ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 3, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
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
                        FlatDecimaldecimal0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var firstItems2 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 62, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
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
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[34], false);
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
            dbType: (System.Data.DbType)(11))]
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 119, query1, 140, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[34], false);
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
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 110, query1, 62, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
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
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 187, query1, 13, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

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
                        FlatDecimaldecimal0M.AssertModel(models[27],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[28],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[29],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[30],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[31],_testData[34], false);
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
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems1 = new List<FlatDecimaldecimal0M>();
                var secondItems2 = new List<FlatDecimaldecimal0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatch(connection, 28, query1, 59, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM gedaqtests.decimaldecimal0m m
LEFT JOIN gedaqtests.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
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
            dbType: (System.Data.DbType)(11))]
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatchAsync(connection, 45, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Decimaldecimal0M.AssertModel(models[0],_testData[8], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[9], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[10], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[11], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[12], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[19],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[20],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[21],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[22],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[23],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[24],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[25],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        Decimaldecimal0M.AssertModel(models[28],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[29],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[30],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[31],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[32],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatch(connection, 187, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Decimaldecimal0M.AssertModel(models[0],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Decimaldecimal0M.AssertModel(models[0],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[34], false);
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
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 183);
                var models = await ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
Decimaldecimal0M.AssertModel(models[0],_testData[30], false);Decimaldecimal0M.AssertModel(models[1],_testData[31], false);Decimaldecimal0M.AssertModel(models[2],_testData[32], false);Decimaldecimal0M.AssertModel(models[3],_testData[33], false);Decimaldecimal0M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models =  ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
Decimaldecimal0M.AssertModel(models[0],_testData[15], false);Decimaldecimal0M.AssertModel(models[1],_testData[16], false);Decimaldecimal0M.AssertModel(models[2],_testData[17], false);Decimaldecimal0M.AssertModel(models[3],_testData[18], false);Decimaldecimal0M.AssertModel(models[4],_testData[19], false);Decimaldecimal0M.AssertModel(models[5],_testData[20], false);Decimaldecimal0M.AssertModel(models[6],_testData[21], false);Decimaldecimal0M.AssertModel(models[7],_testData[22], false);Decimaldecimal0M.AssertModel(models[8],_testData[23], false);Decimaldecimal0M.AssertModel(models[9],_testData[24], false);Decimaldecimal0M.AssertModel(models[10],_testData[25], false);Decimaldecimal0M.AssertModel(models[11],_testData[26], false);Decimaldecimal0M.AssertModel(models[12],_testData[27], false);Decimaldecimal0M.AssertModel(models[13],_testData[28], false);Decimaldecimal0M.AssertModel(models[14],_testData[29], false);Decimaldecimal0M.AssertModel(models[15],_testData[30], false);Decimaldecimal0M.AssertModel(models[16],_testData[31], false);Decimaldecimal0M.AssertModel(models[17],_testData[32], false);Decimaldecimal0M.AssertModel(models[18],_testData[33], false);Decimaldecimal0M.AssertModel(models[19],_testData[34], false);
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
FROM gedaqtests.decimaldecimal0m m
LEFT JOIN gedaqtests.decimaldecimal0mi mi ON mi.id = m.decimaldecimal0mi_id
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.831804834541055m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.769710517846559m)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.216512053519512m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.474929643407804m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.353903720971724m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.701063955659897m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.086474835725572m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.763629484774358m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.131127556003932m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.857323852646455m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0695112880804502m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0527899024462735m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.829575530297281m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.11125811906807m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.95677744879606m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.82986197945742m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.645883869135037m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.156492045746368m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.841224451982874m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.72820199434384m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.134488491798557m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.869770546438297m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.107517130814055m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.173272304108692m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.673963594181798m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.202369359346418m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.57818528570657m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.794320940767732m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.672932939834894m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.203979473397618m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.562070690675715m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.363532778261739m)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.443237082193801m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.676934962991946m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.200030355256658m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.801809926907025m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.582584102549199m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.630141014691936m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.376147769659632m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.272746932122193m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0872839651589286m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.627607525716389m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.778082815057413m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.140314729175143m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.71942392282464m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.979304796415299m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.354916829828411m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.992670699071982m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.441882538732819m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.718990821363055m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.253593284236444m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.128181261259337m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.959902735001532m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.365976747280594m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.55741881672777m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.813588168730402m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.04973307982887m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.163997993805723m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.382118527520604m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.463354762828596m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.531400915496271m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.207645599909728m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.884105246974086m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.732573774445965m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.686476931716973m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0737794976243316m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.608574436913296m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.199920666558033m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.797868824720177m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.948545671261524m)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.624733759258318m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.291126273799135m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.202339054910871m)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0820291878051988m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.141588376065254m)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((198)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.876942742993138m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.457081717832899m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0662214835643116m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((199)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.657159778110151m)));//Value

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
                var models =  ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.831804834541055m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.769710517846559m)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.216512053519512m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.474929643407804m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.353903720971724m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.701063955659897m)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.086474835725572m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.763629484774358m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.131127556003932m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.857323852646455m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0695112880804502m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0527899024462735m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.829575530297281m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.11125811906807m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.95677744879606m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.82986197945742m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.645883869135037m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.156492045746368m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.841224451982874m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.72820199434384m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.134488491798557m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.869770546438297m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.107517130814055m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.173272304108692m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.673963594181798m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.202369359346418m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.57818528570657m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.794320940767732m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.672932939834894m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.203979473397618m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.562070690675715m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.363532778261739m)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.443237082193801m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.676934962991946m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.200030355256658m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.801809926907025m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.582584102549199m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.630141014691936m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.376147769659632m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.272746932122193m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0872839651589286m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.627607525716389m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.778082815057413m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.140314729175143m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.71942392282464m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.979304796415299m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.354916829828411m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.992670699071982m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.441882538732819m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.718990821363055m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.253593284236444m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.128181261259337m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.959902735001532m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.365976747280594m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.55741881672777m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.813588168730402m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.04973307982887m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.163997993805723m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.382118527520604m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.463354762828596m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.531400915496271m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.207645599909728m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.884105246974086m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.732573774445965m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.686476931716973m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0737794976243316m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.608574436913296m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.199920666558033m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.797868824720177m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.948545671261524m)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.624733759258318m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.291126273799135m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.202339054910871m)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0820291878051988m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.141588376065254m)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((198)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.876942742993138m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.457081717832899m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0662214835643116m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((199)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.657159778110151m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

