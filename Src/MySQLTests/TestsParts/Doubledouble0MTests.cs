

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
    internal partial interface IDoubleSingleTypedouble
    {
    }
    
    internal partial class DoubleSingleTypedouble : IDoubleSingleTypedouble
    {


#region TestData

        private readonly Doubledouble0M[] _testData = new Doubledouble0M[]
        {
            new Doubledouble0M
{
    Id = 8,
    Value = 0.6732611444868305d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 16,
    Value = 0.8600012119890976d,
    ModelInner = new Doubledouble0MI
{
    Id = 6,
    Value = 0.3558700826978852d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 24,
    Value = 0.8197897497446158d,
    ModelInner = null,
    NullableValue = 0.8674245911689566d,
},
            new Doubledouble0M
{
    Id = 30,
    Value = 0.9011382650556702d,
    ModelInner = new Doubledouble0MI
{
    Id = 7,
    Value = 0.17126031171813083d,
    NullableValue = null,
},
    NullableValue = 0.0023460140746810465d,
},
            new Doubledouble0M
{
    Id = 36,
    Value = 0.94646225597764d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 40,
    Value = 0.7966434758204454d,
    ModelInner = new Doubledouble0MI
{
    Id = 8,
    Value = 0.2791802207045688d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 42,
    Value = 0.49607262227239557d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 43,
    Value = 0.9382655136218336d,
    ModelInner = new Doubledouble0MI
{
    Id = 11,
    Value = 0.7306091928156278d,
    NullableValue = 0.8859718809143002d,
},
    NullableValue = 0.4943193788032477d,
},
            new Doubledouble0M
{
    Id = 52,
    Value = 0.44416802145201706d,
    ModelInner = null,
    NullableValue = 0.4368326056996451d,
},
            new Doubledouble0M
{
    Id = 58,
    Value = 0.14273995363571734d,
    ModelInner = new Doubledouble0MI
{
    Id = 15,
    Value = 0.36187929521308226d,
    NullableValue = null,
},
    NullableValue = 0.5141712292799419d,
},
            new Doubledouble0M
{
    Id = 66,
    Value = 0.37663685349538656d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 72,
    Value = 0.6291086804879703d,
    ModelInner = new Doubledouble0MI
{
    Id = 19,
    Value = 0.1479407928504377d,
    NullableValue = 0.43674051046614126d,
},
    NullableValue = 0.49584555397805363d,
},
            new Doubledouble0M
{
    Id = 75,
    Value = 0.06489532030002088d,
    ModelInner = null,
    NullableValue = 0.18719995146876933d,
},
            new Doubledouble0M
{
    Id = 77,
    Value = 0.7803625211396336d,
    ModelInner = new Doubledouble0MI
{
    Id = 22,
    Value = 0.13203787213171758d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 78,
    Value = 0.9121149609492978d,
    ModelInner = null,
    NullableValue = 0.16280405835970813d,
},
            new Doubledouble0M
{
    Id = 79,
    Value = 0.5137479394869712d,
    ModelInner = new Doubledouble0MI
{
    Id = 27,
    Value = 0.11663259347047972d,
    NullableValue = null,
},
    NullableValue = 0.7169694236354808d,
},
            new Doubledouble0M
{
    Id = 82,
    Value = 0.29219281995199975d,
    ModelInner = null,
    NullableValue = 0.5984072191331836d,
},
            new Doubledouble0M
{
    Id = 89,
    Value = 0.6508958810560893d,
    ModelInner = new Doubledouble0MI
{
    Id = 32,
    Value = 0.056473371160750796d,
    NullableValue = null,
},
    NullableValue = 0.7432393917135929d,
},
            new Doubledouble0M
{
    Id = 92,
    Value = 0.2681104840353149d,
    ModelInner = null,
    NullableValue = 0.27631722114978907d,
},
            new Doubledouble0M
{
    Id = 95,
    Value = 0.1757481960958618d,
    ModelInner = new Doubledouble0MI
{
    Id = 37,
    Value = 0.461546124955289d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 100,
    Value = 0.4274128178738299d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 103,
    Value = 0.2455188349451226d,
    ModelInner = new Doubledouble0MI
{
    Id = 46,
    Value = 0.8048825610748283d,
    NullableValue = 0.293576817778883d,
},
    NullableValue = 0.31869415393377853d,
},
            new Doubledouble0M
{
    Id = 108,
    Value = 0.16309629276003856d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 109,
    Value = 0.5011598238535726d,
    ModelInner = new Doubledouble0MI
{
    Id = 54,
    Value = 0.17023479439353906d,
    NullableValue = 0.627917768561204d,
},
    NullableValue = 0.6093520870236118d,
},
            new Doubledouble0M
{
    Id = 110,
    Value = 0.2949332363645307d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 111,
    Value = 0.8747956476109411d,
    ModelInner = new Doubledouble0MI
{
    Id = 60,
    Value = 0.10569552665090676d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 116,
    Value = 0.8334433288718863d,
    ModelInner = null,
    NullableValue = 0.27997032796221843d,
},
            new Doubledouble0M
{
    Id = 124,
    Value = 0.0878812198963499d,
    ModelInner = new Doubledouble0MI
{
    Id = 63,
    Value = 0.8718918144134603d,
    NullableValue = 0.08106181367559806d,
},
    NullableValue = 0.34835196448593597d,
},
            new Doubledouble0M
{
    Id = 125,
    Value = 0.6933765300285968d,
    ModelInner = null,
    NullableValue = 0.30030928241129295d,
},
            new Doubledouble0M
{
    Id = 133,
    Value = 0.5953234792466197d,
    ModelInner = new Doubledouble0MI
{
    Id = 66,
    Value = 0.8677679834611364d,
    NullableValue = 0.4484134654425458d,
},
    NullableValue = 0.7881053600086498d,
},
            new Doubledouble0M
{
    Id = 136,
    Value = 0.6161916433848811d,
    ModelInner = null,
    NullableValue = 0.6684935417906741d,
},
            new Doubledouble0M
{
    Id = 137,
    Value = 0.825302806071059d,
    ModelInner = new Doubledouble0MI
{
    Id = 72,
    Value = 0.5223615481031587d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 139,
    Value = 0.5113987132732826d,
    ModelInner = null,
    NullableValue = 0.7042340166038792d,
},
            new Doubledouble0M
{
    Id = 141,
    Value = 0.18717274068191259d,
    ModelInner = new Doubledouble0MI
{
    Id = 77,
    Value = 0.5502370850167978d,
    NullableValue = 0.1681350621493649d,
},
    NullableValue = 0.5930379881958441d,
},
            new Doubledouble0M
{
    Id = 149,
    Value = 0.28652820916505106d,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0mi(
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(5)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(5))]
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

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0mi(
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
            asPartInterface: typeof(IDoubleSingleTypedouble)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8), 
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

                changedRows =  ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0m(
	id,
    value,
    nullablevalue,
    doubledouble0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doubledouble0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(5)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(5),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doubledouble0mi_id", 
                methodParametrName: "doubledouble0mi_id", 
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

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledouble0m(
	id,
    value,
    nullablevalue,
    doubledouble0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doubledouble0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Double), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doubledouble0mi_id", 
                methodParametrName: "doubledouble0mi_id", 
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

                changedRows =  ((IDoubleSingleTypedouble)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble0M), typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                await((IDoubleSingleTypedouble)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                ((IDoubleSingleTypedouble)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypedouble)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypedouble)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
                var models = await((IDoubleSingleTypedouble)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleSingleTypedouble)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble0M), typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                await((IDoubleSingleTypedouble)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                ((IDoubleSingleTypedouble)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypedouble)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
                var models = await((IDoubleSingleTypedouble)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleSingleTypedouble)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble0M), typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                await((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 116;
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
                var models = await((IDoubleSingleTypedouble)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Doubledouble0M.AssertModel(models[0],_testData[2], false);
                        Doubledouble0M.AssertModel(models[1],_testData[3], false);
                        Doubledouble0M.AssertModel(models[2],_testData[4], false);
                        Doubledouble0M.AssertModel(models[3],_testData[5], false);
                        Doubledouble0M.AssertModel(models[4],_testData[6], false);
                        Doubledouble0M.AssertModel(models[5],_testData[7], false);
                        Doubledouble0M.AssertModel(models[6],_testData[8], false);
                        Doubledouble0M.AssertModel(models[7],_testData[9], false);
                        Doubledouble0M.AssertModel(models[8],_testData[10], false);
                        Doubledouble0M.AssertModel(models[9],_testData[11], false);
                        Doubledouble0M.AssertModel(models[10],_testData[12], false);
                        Doubledouble0M.AssertModel(models[11],_testData[13], false);
                        Doubledouble0M.AssertModel(models[12],_testData[14], false);
                        Doubledouble0M.AssertModel(models[13],_testData[15], false);
                        Doubledouble0M.AssertModel(models[14],_testData[16], false);
                        Doubledouble0M.AssertModel(models[15],_testData[17], false);
                        Doubledouble0M.AssertModel(models[16],_testData[18], false);
                        Doubledouble0M.AssertModel(models[17],_testData[19], false);
                        Doubledouble0M.AssertModel(models[18],_testData[20], false);
                        Doubledouble0M.AssertModel(models[19],_testData[21], false);
                        Doubledouble0M.AssertModel(models[20],_testData[22], false);
                        Doubledouble0M.AssertModel(models[21],_testData[23], false);
                        Doubledouble0M.AssertModel(models[22],_testData[24], false);
                        Doubledouble0M.AssertModel(models[23],_testData[25], false);
                        Doubledouble0M.AssertModel(models[24],_testData[26], false);
                        Doubledouble0M.AssertModel(models[25],_testData[27], false);
                        Doubledouble0M.AssertModel(models[26],_testData[28], false);
                        Doubledouble0M.AssertModel(models[27],_testData[29], false);
                        Doubledouble0M.AssertModel(models[28],_testData[30], false);
                        Doubledouble0M.AssertModel(models[29],_testData[31], false);
                        Doubledouble0M.AssertModel(models[30],_testData[32], false);
                        Doubledouble0M.AssertModel(models[31],_testData[33], false);
                        Doubledouble0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Doubledouble0M.AssertModel(models[0],_testData[23], false);
                        Doubledouble0M.AssertModel(models[1],_testData[24], false);
                        Doubledouble0M.AssertModel(models[2],_testData[25], false);
                        Doubledouble0M.AssertModel(models[3],_testData[26], false);
                        Doubledouble0M.AssertModel(models[4],_testData[27], false);
                        Doubledouble0M.AssertModel(models[5],_testData[28], false);
                        Doubledouble0M.AssertModel(models[6],_testData[29], false);
                        Doubledouble0M.AssertModel(models[7],_testData[30], false);
                        Doubledouble0M.AssertModel(models[8],_testData[31], false);
                        Doubledouble0M.AssertModel(models[9],_testData[32], false);
                        Doubledouble0M.AssertModel(models[10],_testData[33], false);
                        Doubledouble0M.AssertModel(models[11],_testData[34], false);
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
                var models = ((IDoubleSingleTypedouble)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Doubledouble0M.AssertModel(models[0],_testData[22], false);
                        Doubledouble0M.AssertModel(models[1],_testData[23], false);
                        Doubledouble0M.AssertModel(models[2],_testData[24], false);
                        Doubledouble0M.AssertModel(models[3],_testData[25], false);
                        Doubledouble0M.AssertModel(models[4],_testData[26], false);
                        Doubledouble0M.AssertModel(models[5],_testData[27], false);
                        Doubledouble0M.AssertModel(models[6],_testData[28], false);
                        Doubledouble0M.AssertModel(models[7],_testData[29], false);
                        Doubledouble0M.AssertModel(models[8],_testData[30], false);
                        Doubledouble0M.AssertModel(models[9],_testData[31], false);
                        Doubledouble0M.AssertModel(models[10],_testData[32], false);
                        Doubledouble0M.AssertModel(models[11],_testData[33], false);
                        Doubledouble0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble0M.AssertModel(models[0],_testData[1], false);
                        Doubledouble0M.AssertModel(models[1],_testData[2], false);
                        Doubledouble0M.AssertModel(models[2],_testData[3], false);
                        Doubledouble0M.AssertModel(models[3],_testData[4], false);
                        Doubledouble0M.AssertModel(models[4],_testData[5], false);
                        Doubledouble0M.AssertModel(models[5],_testData[6], false);
                        Doubledouble0M.AssertModel(models[6],_testData[7], false);
                        Doubledouble0M.AssertModel(models[7],_testData[8], false);
                        Doubledouble0M.AssertModel(models[8],_testData[9], false);
                        Doubledouble0M.AssertModel(models[9],_testData[10], false);
                        Doubledouble0M.AssertModel(models[10],_testData[11], false);
                        Doubledouble0M.AssertModel(models[11],_testData[12], false);
                        Doubledouble0M.AssertModel(models[12],_testData[13], false);
                        Doubledouble0M.AssertModel(models[13],_testData[14], false);
                        Doubledouble0M.AssertModel(models[14],_testData[15], false);
                        Doubledouble0M.AssertModel(models[15],_testData[16], false);
                        Doubledouble0M.AssertModel(models[16],_testData[17], false);
                        Doubledouble0M.AssertModel(models[17],_testData[18], false);
                        Doubledouble0M.AssertModel(models[18],_testData[19], false);
                        Doubledouble0M.AssertModel(models[19],_testData[20], false);
                        Doubledouble0M.AssertModel(models[20],_testData[21], false);
                        Doubledouble0M.AssertModel(models[21],_testData[22], false);
                        Doubledouble0M.AssertModel(models[22],_testData[23], false);
                        Doubledouble0M.AssertModel(models[23],_testData[24], false);
                        Doubledouble0M.AssertModel(models[24],_testData[25], false);
                        Doubledouble0M.AssertModel(models[25],_testData[26], false);
                        Doubledouble0M.AssertModel(models[26],_testData[27], false);
                        Doubledouble0M.AssertModel(models[27],_testData[28], false);
                        Doubledouble0M.AssertModel(models[28],_testData[29], false);
                        Doubledouble0M.AssertModel(models[29],_testData[30], false);
                        Doubledouble0M.AssertModel(models[30],_testData[31], false);
                        Doubledouble0M.AssertModel(models[31],_testData[32], false);
                        Doubledouble0M.AssertModel(models[32],_testData[33], false);
                        Doubledouble0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble0M), typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                await((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 8, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 139, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble0M>();
                var models2 = new List<FlatDoubledouble0M>();
                ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 66, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var firstItems2 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatch(connection, 52, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 36, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[24],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[25],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[26],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[27],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[28],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[23],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[24],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[25],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[26],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[27],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[28],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[29],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[30],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[31],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 36, query1, 133, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatch(connection, 125, query1, 139, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
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
FROM gedaqtests.doubledouble0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble0M>();
                var secondItems1 = new List<FlatDoubledouble0M>();
                var secondItems2 = new List<FlatDoubledouble0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatch(connection, 110, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble)),
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
                var models = await((IDoubleSingleTypedouble)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatchAsync(connection, 30, 111))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Doubledouble0M.AssertModel(models[0],_testData[4], false);
                        Doubledouble0M.AssertModel(models[1],_testData[5], false);
                        Doubledouble0M.AssertModel(models[2],_testData[6], false);
                        Doubledouble0M.AssertModel(models[3],_testData[7], false);
                        Doubledouble0M.AssertModel(models[4],_testData[8], false);
                        Doubledouble0M.AssertModel(models[5],_testData[9], false);
                        Doubledouble0M.AssertModel(models[6],_testData[10], false);
                        Doubledouble0M.AssertModel(models[7],_testData[11], false);
                        Doubledouble0M.AssertModel(models[8],_testData[12], false);
                        Doubledouble0M.AssertModel(models[9],_testData[13], false);
                        Doubledouble0M.AssertModel(models[10],_testData[14], false);
                        Doubledouble0M.AssertModel(models[11],_testData[15], false);
                        Doubledouble0M.AssertModel(models[12],_testData[16], false);
                        Doubledouble0M.AssertModel(models[13],_testData[17], false);
                        Doubledouble0M.AssertModel(models[14],_testData[18], false);
                        Doubledouble0M.AssertModel(models[15],_testData[19], false);
                        Doubledouble0M.AssertModel(models[16],_testData[20], false);
                        Doubledouble0M.AssertModel(models[17],_testData[21], false);
                        Doubledouble0M.AssertModel(models[18],_testData[22], false);
                        Doubledouble0M.AssertModel(models[19],_testData[23], false);
                        Doubledouble0M.AssertModel(models[20],_testData[24], false);
                        Doubledouble0M.AssertModel(models[21],_testData[25], false);
                        Doubledouble0M.AssertModel(models[22],_testData[26], false);
                        Doubledouble0M.AssertModel(models[23],_testData[27], false);
                        Doubledouble0M.AssertModel(models[24],_testData[28], false);
                        Doubledouble0M.AssertModel(models[25],_testData[29], false);
                        Doubledouble0M.AssertModel(models[26],_testData[30], false);
                        Doubledouble0M.AssertModel(models[27],_testData[31], false);
                        Doubledouble0M.AssertModel(models[28],_testData[32], false);
                        Doubledouble0M.AssertModel(models[29],_testData[33], false);
                        Doubledouble0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble0M.AssertModel(models[0],_testData[26], false);
                        Doubledouble0M.AssertModel(models[1],_testData[27], false);
                        Doubledouble0M.AssertModel(models[2],_testData[28], false);
                        Doubledouble0M.AssertModel(models[3],_testData[29], false);
                        Doubledouble0M.AssertModel(models[4],_testData[30], false);
                        Doubledouble0M.AssertModel(models[5],_testData[31], false);
                        Doubledouble0M.AssertModel(models[6],_testData[32], false);
                        Doubledouble0M.AssertModel(models[7],_testData[33], false);
                        Doubledouble0M.AssertModel(models[8],_testData[34], false);
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
                var models = ((IDoubleSingleTypedouble)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatch(connection, 116, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble0M.AssertModel(models[0],_testData[27], false);
                        Doubledouble0M.AssertModel(models[1],_testData[28], false);
                        Doubledouble0M.AssertModel(models[2],_testData[29], false);
                        Doubledouble0M.AssertModel(models[3],_testData[30], false);
                        Doubledouble0M.AssertModel(models[4],_testData[31], false);
                        Doubledouble0M.AssertModel(models[5],_testData[32], false);
                        Doubledouble0M.AssertModel(models[6],_testData[33], false);
                        Doubledouble0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble0M.AssertModel(models[0],_testData[16], false);
                        Doubledouble0M.AssertModel(models[1],_testData[17], false);
                        Doubledouble0M.AssertModel(models[2],_testData[18], false);
                        Doubledouble0M.AssertModel(models[3],_testData[19], false);
                        Doubledouble0M.AssertModel(models[4],_testData[20], false);
                        Doubledouble0M.AssertModel(models[5],_testData[21], false);
                        Doubledouble0M.AssertModel(models[6],_testData[22], false);
                        Doubledouble0M.AssertModel(models[7],_testData[23], false);
                        Doubledouble0M.AssertModel(models[8],_testData[24], false);
                        Doubledouble0M.AssertModel(models[9],_testData[25], false);
                        Doubledouble0M.AssertModel(models[10],_testData[26], false);
                        Doubledouble0M.AssertModel(models[11],_testData[27], false);
                        Doubledouble0M.AssertModel(models[12],_testData[28], false);
                        Doubledouble0M.AssertModel(models[13],_testData[29], false);
                        Doubledouble0M.AssertModel(models[14],_testData[30], false);
                        Doubledouble0M.AssertModel(models[15],_testData[31], false);
                        Doubledouble0M.AssertModel(models[16],_testData[32], false);
                        Doubledouble0M.AssertModel(models[17],_testData[33], false);
                        Doubledouble0M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((IDoubleSingleTypedouble)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models = await ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                Doubledouble0M.AssertModel(models[0],_testData[14], false);
                Doubledouble0M.AssertModel(models[1],_testData[15], false);
                Doubledouble0M.AssertModel(models[2],_testData[16], false);
                Doubledouble0M.AssertModel(models[3],_testData[17], false);
                Doubledouble0M.AssertModel(models[4],_testData[18], false);
                Doubledouble0M.AssertModel(models[5],_testData[19], false);
                Doubledouble0M.AssertModel(models[6],_testData[20], false);
                Doubledouble0M.AssertModel(models[7],_testData[21], false);
                Doubledouble0M.AssertModel(models[8],_testData[22], false);
                Doubledouble0M.AssertModel(models[9],_testData[23], false);
                Doubledouble0M.AssertModel(models[10],_testData[24], false);
                Doubledouble0M.AssertModel(models[11],_testData[25], false);
                Doubledouble0M.AssertModel(models[12],_testData[26], false);
                Doubledouble0M.AssertModel(models[13],_testData[27], false);
                Doubledouble0M.AssertModel(models[14],_testData[28], false);
                Doubledouble0M.AssertModel(models[15],_testData[29], false);
                Doubledouble0M.AssertModel(models[16],_testData[30], false);
                Doubledouble0M.AssertModel(models[17],_testData[31], false);
                Doubledouble0M.AssertModel(models[18],_testData[32], false);
                Doubledouble0M.AssertModel(models[19],_testData[33], false);
                Doubledouble0M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypedouble)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 42);
                var models =  ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                Doubledouble0M.AssertModel(models[0],_testData[7], false);
                Doubledouble0M.AssertModel(models[1],_testData[8], false);
                Doubledouble0M.AssertModel(models[2],_testData[9], false);
                Doubledouble0M.AssertModel(models[3],_testData[10], false);
                Doubledouble0M.AssertModel(models[4],_testData[11], false);
                Doubledouble0M.AssertModel(models[5],_testData[12], false);
                Doubledouble0M.AssertModel(models[6],_testData[13], false);
                Doubledouble0M.AssertModel(models[7],_testData[14], false);
                Doubledouble0M.AssertModel(models[8],_testData[15], false);
                Doubledouble0M.AssertModel(models[9],_testData[16], false);
                Doubledouble0M.AssertModel(models[10],_testData[17], false);
                Doubledouble0M.AssertModel(models[11],_testData[18], false);
                Doubledouble0M.AssertModel(models[12],_testData[19], false);
                Doubledouble0M.AssertModel(models[13],_testData[20], false);
                Doubledouble0M.AssertModel(models[14],_testData[21], false);
                Doubledouble0M.AssertModel(models[15],_testData[22], false);
                Doubledouble0M.AssertModel(models[16],_testData[23], false);
                Doubledouble0M.AssertModel(models[17],_testData[24], false);
                Doubledouble0M.AssertModel(models[18],_testData[25], false);
                Doubledouble0M.AssertModel(models[19],_testData[26], false);
                Doubledouble0M.AssertModel(models[20],_testData[27], false);
                Doubledouble0M.AssertModel(models[21],_testData[28], false);
                Doubledouble0M.AssertModel(models[22],_testData[29], false);
                Doubledouble0M.AssertModel(models[23],_testData[30], false);
                Doubledouble0M.AssertModel(models[24],_testData[31], false);
                Doubledouble0M.AssertModel(models[25],_testData[32], false);
                Doubledouble0M.AssertModel(models[26],_testData[33], false);
                Doubledouble0M.AssertModel(models[27],_testData[34], false);
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
FROM gedaqtests.doubledouble0m m
LEFT JOIN gedaqtests.doubledouble0mi mi ON mi.id = m.doubledouble0mi_id
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
            asPartInterface: typeof(IDoubleSingleTypedouble))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6732611444868305d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8600012119890976d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3558700826978852d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8197897497446158d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8674245911689566d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9011382650556702d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.17126031171813083d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.0023460140746810465d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.94646225597764d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7966434758204454d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2791802207045688d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.49607262227239557d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9382655136218336d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7306091928156278d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8859718809143002d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4943193788032477d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.44416802145201706d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4368326056996451d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14273995363571734d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.36187929521308226d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5141712292799419d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.37663685349538656d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6291086804879703d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1479407928504377d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.43674051046614126d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.49584555397805363d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.06489532030002088d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.18719995146876933d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7803625211396336d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.13203787213171758d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9121149609492978d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.16280405835970813d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5137479394869712d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11663259347047972d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7169694236354808d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29219281995199975d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5984072191331836d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6508958810560893d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.056473371160750796d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7432393917135929d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2681104840353149d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.27631722114978907d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1757481960958618d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.461546124955289d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4274128178738299d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2455188349451226d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8048825610748283d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.293576817778883d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.31869415393377853d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16309629276003856d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5011598238535726d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.17023479439353906d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.627917768561204d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6093520870236118d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2949332363645307d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8747956476109411d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.10569552665090676d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8334433288718863d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.27997032796221843d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.0878812198963499d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8718918144134603d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.08106181367559806d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.34835196448593597d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6933765300285968d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.30030928241129295d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5953234792466197d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8677679834611364d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4484134654425458d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7881053600086498d)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6161916433848811d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6684935417906741d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.825302806071059d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5223615481031587d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5113987132732826d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7042340166038792d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.18717274068191259d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5502370850167978d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.1681350621493649d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5930379881958441d)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.28652820916505106d)));//Value

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
                var models =  ((IDoubleSingleTypedouble)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6732611444868305d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8600012119890976d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3558700826978852d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8197897497446158d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8674245911689566d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9011382650556702d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.17126031171813083d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.0023460140746810465d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.94646225597764d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7966434758204454d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2791802207045688d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.49607262227239557d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9382655136218336d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7306091928156278d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8859718809143002d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4943193788032477d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.44416802145201706d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.4368326056996451d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14273995363571734d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.36187929521308226d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5141712292799419d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.37663685349538656d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6291086804879703d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1479407928504377d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.43674051046614126d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.49584555397805363d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.06489532030002088d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.18719995146876933d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7803625211396336d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.13203787213171758d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9121149609492978d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.16280405835970813d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5137479394869712d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11663259347047972d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7169694236354808d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29219281995199975d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5984072191331836d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6508958810560893d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.056473371160750796d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7432393917135929d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2681104840353149d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.27631722114978907d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1757481960958618d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.461546124955289d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4274128178738299d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2455188349451226d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8048825610748283d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.293576817778883d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.31869415393377853d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16309629276003856d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5011598238535726d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.17023479439353906d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.627917768561204d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6093520870236118d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2949332363645307d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8747956476109411d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.10569552665090676d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8334433288718863d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.27997032796221843d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.0878812198963499d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8718918144134603d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.08106181367559806d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.34835196448593597d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6933765300285968d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.30030928241129295d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5953234792466197d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8677679834611364d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4484134654425458d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7881053600086498d)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6161916433848811d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6684935417906741d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.825302806071059d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5223615481031587d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5113987132732826d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7042340166038792d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.18717274068191259d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5502370850167978d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.1681350621493649d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5930379881958441d)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.28652820916505106d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

