

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

        private readonly DecimaldecimalE0M[] _testData = new DecimaldecimalE0M[]
        {
            new DecimaldecimalE0M
{
    Id = 6,
    Value = 0.0528575818250448m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 12,
    Value = 0.603832029562912m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 5,
    Value = 0.260806271786877m,
    NullableValue = 0.958176856508353m,
},
    NullableValue = 0.6092839831716m,
},
            new DecimaldecimalE0M
{
    Id = 18,
    Value = 0.338677398480578m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 22,
    Value = 0.762039697015689m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 7,
    Value = 0.926655590902703m,
    NullableValue = 0.654850298283424m,
},
    NullableValue = 0.0684941410909319m,
},
            new DecimaldecimalE0M
{
    Id = 30,
    Value = 0.0761903834581244m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 35,
    Value = 0.306944320926289m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 11,
    Value = 0.691967872179052m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 38,
    Value = 0.444164060720834m,
    ModelInner = null,
    NullableValue = 0.99122393822522m,
},
            new DecimaldecimalE0M
{
    Id = 43,
    Value = 0.364889975996021m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 14,
    Value = 0.35924117810379m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 44,
    Value = 0.609837166769756m,
    ModelInner = null,
    NullableValue = 0.605074805808919m,
},
            new DecimaldecimalE0M
{
    Id = 48,
    Value = 0.871887080988258m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 22,
    Value = 0.041981469287259m,
    NullableValue = 0.775268872780682m,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 54,
    Value = 0.167114878033369m,
    ModelInner = null,
    NullableValue = 0.826820720756182m,
},
            new DecimaldecimalE0M
{
    Id = 62,
    Value = 0.0736672666581615m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 31,
    Value = 0.585720319276169m,
    NullableValue = 0.46557273195816m,
},
    NullableValue = 0.167438120787303m,
},
            new DecimaldecimalE0M
{
    Id = 63,
    Value = 0.588272152126854m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 70,
    Value = 0.815650522244836m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 37,
    Value = 0.52111593207806m,
    NullableValue = 0.399724792681634m,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 78,
    Value = 0.0841641063243054m,
    ModelInner = null,
    NullableValue = 0.30037351102501m,
},
            new DecimaldecimalE0M
{
    Id = 79,
    Value = 0.261925203538928m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 40,
    Value = 0.0592847863116155m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 88,
    Value = 0.334990613737044m,
    ModelInner = null,
    NullableValue = 0.337427872712389m,
},
            new DecimaldecimalE0M
{
    Id = 94,
    Value = 0.00949578795125172m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 46,
    Value = 0.970059575125687m,
    NullableValue = null,
},
    NullableValue = 0.599962209140857m,
},
            new DecimaldecimalE0M
{
    Id = 99,
    Value = 0.515530294764152m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 101,
    Value = 0.36217664049956m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 50,
    Value = 0.209721400520425m,
    NullableValue = 0.947107425726624m,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 110,
    Value = 0.924031882766022m,
    ModelInner = null,
    NullableValue = 0.283161761634023m,
},
            new DecimaldecimalE0M
{
    Id = 111,
    Value = 0.810443540038672m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 57,
    Value = 0.948223324917279m,
    NullableValue = 0.0353144977936482m,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 115,
    Value = 0.491760178025768m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 119,
    Value = 0.243005015143338m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 61,
    Value = 0.308041883713353m,
    NullableValue = 0.156749005891141m,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 121,
    Value = 0.349257573881473m,
    ModelInner = null,
    NullableValue = 0.618135010056484m,
},
            new DecimaldecimalE0M
{
    Id = 127,
    Value = 0.491726742903927m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 62,
    Value = 0.777370889360177m,
    NullableValue = null,
},
    NullableValue = 0.302009090665839m,
},
            new DecimaldecimalE0M
{
    Id = 129,
    Value = 0.821036299991427m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 130,
    Value = 0.130814917270632m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 69,
    Value = 0.432047442313165m,
    NullableValue = null,
},
    NullableValue = 0.199066449324942m,
},
            new DecimaldecimalE0M
{
    Id = 139,
    Value = 0.264263897962781m,
    ModelInner = null,
    NullableValue = 0.0638713469139936m,
},
            new DecimaldecimalE0M
{
    Id = 145,
    Value = 0.69365870609095m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 74,
    Value = 0.814815698408214m,
    NullableValue = null,
},
    NullableValue = 0.747946270735723m,
},
            new DecimaldecimalE0M
{
    Id = 148,
    Value = 0.465774848247247m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 150,
    Value = 0.747413519007988m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 75,
    Value = 0.54263176441716m,
    NullableValue = 0.890191382176868m,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 154,
    Value = 0.849423179288924m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 163,
    Value = 0.0428800845853184m,
    ModelInner = new DecimaldecimalE0MI
{
    Id = 80,
    Value = 0.243296636093843m,
    NullableValue = 0.970300099428874m,
},
    NullableValue = null,
},
            new DecimaldecimalE0M
{
    Id = 168,
    Value = 0.444595028549515m,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.decimaldecimale0mi(
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
INSERT INTO gedaqtests.decimaldecimale0mi(
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
INSERT INTO gedaqtests.decimaldecimale0m(
	id,
    value,
    nullablevalue,
    decimaldecimale0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimaldecimale0mi_id
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
                parametrName: "decimaldecimale0mi_id", 
                methodParametrName: "decimaldecimale0mi_id", 
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
INSERT INTO gedaqtests.decimaldecimale0m(
	id,
    value,
    nullablevalue,
    decimaldecimale0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimaldecimale0mi_id
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
                parametrName: "decimaldecimale0mi_id", 
                methodParametrName: "decimaldecimale0mi_id", 
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
            queryMapTypes: [typeof(FlatDecimaldecimalE0M), typeof(FlatDecimaldecimalE0M)],
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
FROM gedaqtests.decimaldecimale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                await((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.decimaldecimale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                ((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M)],
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
FROM gedaqtests.decimaldecimale0m m
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
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.decimaldecimale0m m
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
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.decimaldecimale0m m
LEFT JOIN gedaqtests.decimaldecimale0mi mi ON mi.id = m.decimaldecimale0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimaldecimalE0M)],
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M), typeof(FlatDecimaldecimalE0M)],
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
FROM gedaqtests.decimaldecimale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                await((IDecimalSingleTypedecimal)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.decimaldecimale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                ((IDecimalSingleTypedecimal)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M)],
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
FROM gedaqtests.decimaldecimale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypedecimal)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.decimaldecimale0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypedecimal)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.decimaldecimale0m m
LEFT JOIN gedaqtests.decimaldecimale0mi mi ON mi.id = m.decimaldecimale0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimaldecimalE0M)],
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M), typeof(FlatDecimaldecimalE0M)],
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                await((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M)],
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
FROM gedaqtests.decimaldecimale0m m
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
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[3], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[17],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[18],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[19],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[20],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[21],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[22],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[23],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[24],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[25],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[26],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[27],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[28],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[29],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[30],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[17],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[18],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[19],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM gedaqtests.decimaldecimale0m m
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
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM gedaqtests.decimaldecimale0m m
LEFT JOIN gedaqtests.decimaldecimale0mi mi ON mi.id = m.decimaldecimale0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimaldecimalE0M)],
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[8], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[9], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[10], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[11], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[12], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[13], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[14], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[15], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[16], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[17], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[18], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[16],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[17],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[18],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[19],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[20],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[21],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[22],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[23],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[24],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[25],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[26],_testData[34], false);
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M), typeof(FlatDecimaldecimalE0M)],
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                await((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 139, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 139, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimaldecimalE0M>();
                var models2 = new List<FlatDecimaldecimalE0M>();
                ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimaldecimalE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 63, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var firstItems2 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 139, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimaldecimalE0M)],
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 78, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[17],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[18],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[17],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[18],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[19],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[20],_testData[34], false);
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
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 99, query1, 119, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 119, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimaldecimalE0M.AssertModel(models[0],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(models[1],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(models[2],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(models[3],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(models[4],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(models[5],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(models[6],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(models[7],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(models[8],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(models[9],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(models[10],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(models[11],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(models[12],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(models[13],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(models[14],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(models[15],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(models[16],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(models[17],_testData[34], false);
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
FROM gedaqtests.decimaldecimale0m m
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
FROM gedaqtests.decimaldecimale0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems1 = new List<FlatDecimaldecimalE0M>();
                var secondItems2 = new List<FlatDecimaldecimalE0M>();
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatch(connection, 22, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDecimaldecimalE0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM gedaqtests.decimaldecimale0m m
LEFT JOIN gedaqtests.decimaldecimale0mi mi ON mi.id = m.decimaldecimale0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimaldecimalE0M)],
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatchAsync(connection, 63, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[13], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[14], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[15], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[16], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[17], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[18], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[16],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[17],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[18],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[19],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[20],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[34], false);
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
                    DecimaldecimalE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatch(connection, 63, 111))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[13], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[14], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[15], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[16], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[17], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[18], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[19], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[20], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[21], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[13],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[14],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[15],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[16],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[17],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[18],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[19],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[20],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimaldecimalE0M.AssertModel(models[0],_testData[22], false);
                        DecimaldecimalE0M.AssertModel(models[1],_testData[23], false);
                        DecimaldecimalE0M.AssertModel(models[2],_testData[24], false);
                        DecimaldecimalE0M.AssertModel(models[3],_testData[25], false);
                        DecimaldecimalE0M.AssertModel(models[4],_testData[26], false);
                        DecimaldecimalE0M.AssertModel(models[5],_testData[27], false);
                        DecimaldecimalE0M.AssertModel(models[6],_testData[28], false);
                        DecimaldecimalE0M.AssertModel(models[7],_testData[29], false);
                        DecimaldecimalE0M.AssertModel(models[8],_testData[30], false);
                        DecimaldecimalE0M.AssertModel(models[9],_testData[31], false);
                        DecimaldecimalE0M.AssertModel(models[10],_testData[32], false);
                        DecimaldecimalE0M.AssertModel(models[11],_testData[33], false);
                        DecimaldecimalE0M.AssertModel(models[12],_testData[34], false);
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
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models = await ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                DecimaldecimalE0M.AssertModel(models[0],_testData[18], false);
                DecimaldecimalE0M.AssertModel(models[1],_testData[19], false);
                DecimaldecimalE0M.AssertModel(models[2],_testData[20], false);
                DecimaldecimalE0M.AssertModel(models[3],_testData[21], false);
                DecimaldecimalE0M.AssertModel(models[4],_testData[22], false);
                DecimaldecimalE0M.AssertModel(models[5],_testData[23], false);
                DecimaldecimalE0M.AssertModel(models[6],_testData[24], false);
                DecimaldecimalE0M.AssertModel(models[7],_testData[25], false);
                DecimaldecimalE0M.AssertModel(models[8],_testData[26], false);
                DecimaldecimalE0M.AssertModel(models[9],_testData[27], false);
                DecimaldecimalE0M.AssertModel(models[10],_testData[28], false);
                DecimaldecimalE0M.AssertModel(models[11],_testData[29], false);
                DecimaldecimalE0M.AssertModel(models[12],_testData[30], false);
                DecimaldecimalE0M.AssertModel(models[13],_testData[31], false);
                DecimaldecimalE0M.AssertModel(models[14],_testData[32], false);
                DecimaldecimalE0M.AssertModel(models[15],_testData[33], false);
                DecimaldecimalE0M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 115);
                var models =  ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                DecimaldecimalE0M.AssertModel(models[0],_testData[23], false);
                DecimaldecimalE0M.AssertModel(models[1],_testData[24], false);
                DecimaldecimalE0M.AssertModel(models[2],_testData[25], false);
                DecimaldecimalE0M.AssertModel(models[3],_testData[26], false);
                DecimaldecimalE0M.AssertModel(models[4],_testData[27], false);
                DecimaldecimalE0M.AssertModel(models[5],_testData[28], false);
                DecimaldecimalE0M.AssertModel(models[6],_testData[29], false);
                DecimaldecimalE0M.AssertModel(models[7],_testData[30], false);
                DecimaldecimalE0M.AssertModel(models[8],_testData[31], false);
                DecimaldecimalE0M.AssertModel(models[9],_testData[32], false);
                DecimaldecimalE0M.AssertModel(models[10],_testData[33], false);
                DecimaldecimalE0M.AssertModel(models[11],_testData[34], false);
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
FROM gedaqtests.decimaldecimale0m m
LEFT JOIN gedaqtests.decimaldecimale0mi mi ON mi.id = m.decimaldecimale0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0528575818250448m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.603832029562912m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.260806271786877m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.958176856508353m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.6092839831716m)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.338677398480578m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.762039697015689m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.926655590902703m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.654850298283424m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0684941410909319m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0761903834581244m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.306944320926289m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.691967872179052m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.444164060720834m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.99122393822522m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.364889975996021m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.35924117810379m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.609837166769756m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.605074805808919m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.871887080988258m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.041981469287259m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.775268872780682m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.167114878033369m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.826820720756182m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0736672666581615m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.585720319276169m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.46557273195816m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.167438120787303m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.588272152126854m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.815650522244836m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.52111593207806m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.399724792681634m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0841641063243054m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.30037351102501m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.261925203538928m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0592847863116155m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.334990613737044m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.337427872712389m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00949578795125172m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.970059575125687m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.599962209140857m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.515530294764152m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.36217664049956m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.209721400520425m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.947107425726624m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.924031882766022m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.283161761634023m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.810443540038672m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.948223324917279m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0353144977936482m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.491760178025768m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.243005015143338m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.308041883713353m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.156749005891141m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.349257573881473m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.618135010056484m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.491726742903927m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.777370889360177m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.302009090665839m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.821036299991427m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.130814917270632m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.432047442313165m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.199066449324942m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.264263897962781m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0638713469139936m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.69365870609095m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.814815698408214m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.747946270735723m)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.465774848247247m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.747413519007988m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.54263176441716m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.890191382176868m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.849423179288924m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0428800845853184m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.243296636093843m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.970300099428874m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.444595028549515m)));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0528575818250448m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.603832029562912m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.260806271786877m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.958176856508353m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.6092839831716m)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.338677398480578m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.762039697015689m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.926655590902703m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.654850298283424m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0684941410909319m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0761903834581244m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.306944320926289m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.691967872179052m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.444164060720834m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.99122393822522m)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.364889975996021m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.35924117810379m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.609837166769756m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.605074805808919m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.871887080988258m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.041981469287259m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.775268872780682m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.167114878033369m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.826820720756182m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0736672666581615m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.585720319276169m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.46557273195816m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.167438120787303m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.588272152126854m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.815650522244836m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.52111593207806m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.399724792681634m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0841641063243054m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.30037351102501m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.261925203538928m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0592847863116155m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.334990613737044m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.337427872712389m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.00949578795125172m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.970059575125687m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.599962209140857m)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.515530294764152m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.36217664049956m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.209721400520425m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.947107425726624m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.924031882766022m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.283161761634023m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.810443540038672m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.948223324917279m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0353144977936482m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.491760178025768m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.243005015143338m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.308041883713353m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.156749005891141m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.349257573881473m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.618135010056484m)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.491726742903927m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.777370889360177m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.302009090665839m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.821036299991427m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.130814917270632m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.432047442313165m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.199066449324942m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.264263897962781m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0638713469139936m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.69365870609095m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.814815698408214m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.747946270735723m)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.465774848247247m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.747413519007988m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.54263176441716m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.890191382176868m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.849423179288924m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0428800845853184m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.243296636093843m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.970300099428874m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.444595028549515m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

