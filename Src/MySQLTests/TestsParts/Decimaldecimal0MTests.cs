

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
    Value = 0.140506141211336m,
    ModelInner = null,
    NullableValue = 0.582655216745095m,
},
            new Decimaldecimal0M
{
    Id = 12,
    Value = 0.642273143752188m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 6,
    Value = 0.498964385283055m,
    NullableValue = 0.0286965115313702m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 13,
    Value = 0.369675500416226m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 18,
    Value = 0.1808565369817m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 15,
    Value = 0.589558892999476m,
    NullableValue = 0.237315203619751m,
},
    NullableValue = 0.329238429980515m,
},
            new Decimaldecimal0M
{
    Id = 20,
    Value = 0.898256706449057m,
    ModelInner = null,
    NullableValue = 0.151468212982475m,
},
            new Decimaldecimal0M
{
    Id = 26,
    Value = 0.5789407655616m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 18,
    Value = 0.998705791341387m,
    NullableValue = 0.54855052256165m,
},
    NullableValue = 0.602482141724418m,
},
            new Decimaldecimal0M
{
    Id = 28,
    Value = 0.452482691025082m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 32,
    Value = 0.0867527385921176m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 21,
    Value = 0.692836781414428m,
    NullableValue = null,
},
    NullableValue = 0.0330941581241571m,
},
            new Decimaldecimal0M
{
    Id = 34,
    Value = 0.315575964030449m,
    ModelInner = null,
    NullableValue = 0.846858823865876m,
},
            new Decimaldecimal0M
{
    Id = 41,
    Value = 0.0987729931843066m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 22,
    Value = 0.2422397499318m,
    NullableValue = 0.367377278847006m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 47,
    Value = 0.719529168898787m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 55,
    Value = 0.344088073095766m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 23,
    Value = 0.227301511241147m,
    NullableValue = null,
},
    NullableValue = 0.739994504291812m,
},
            new Decimaldecimal0M
{
    Id = 60,
    Value = 0.864972679203538m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 66,
    Value = 0.272137316137535m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 29,
    Value = 0.0990938440531454m,
    NullableValue = 0.339739643555933m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 74,
    Value = 0.257466976654479m,
    ModelInner = null,
    NullableValue = 0.0461254848637971m,
},
            new Decimaldecimal0M
{
    Id = 75,
    Value = 0.0436775854103222m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 35,
    Value = 0.446997031391994m,
    NullableValue = null,
},
    NullableValue = 0.381098419280187m,
},
            new Decimaldecimal0M
{
    Id = 84,
    Value = 0.526145713486374m,
    ModelInner = null,
    NullableValue = 0.0556560845518792m,
},
            new Decimaldecimal0M
{
    Id = 93,
    Value = 0.279811083792311m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 41,
    Value = 0.166026846574995m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 95,
    Value = 0.758808743679701m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 100,
    Value = 0.768949703572091m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 49,
    Value = 0.92309283368253m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 102,
    Value = 0.390467966014666m,
    ModelInner = null,
    NullableValue = 0.980847561524872m,
},
            new Decimaldecimal0M
{
    Id = 106,
    Value = 0.411011381495688m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 53,
    Value = 0.0175838147737823m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 111,
    Value = 0.501932019627641m,
    ModelInner = null,
    NullableValue = 0.914070858144056m,
},
            new Decimaldecimal0M
{
    Id = 114,
    Value = 0.521925971827356m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 62,
    Value = 0.39041368219921m,
    NullableValue = 0.705271085030391m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 118,
    Value = 0.875898669328773m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 119,
    Value = 0.51483616694524m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 65,
    Value = 0.532986089209665m,
    NullableValue = 0.664151760340581m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 124,
    Value = 0.531316415755868m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 130,
    Value = 0.6672177662919m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 67,
    Value = 0.664338464102833m,
    NullableValue = 0.460862074925814m,
},
    NullableValue = 0.440082511334004m,
},
            new Decimaldecimal0M
{
    Id = 135,
    Value = 0.374024115159566m,
    ModelInner = null,
    NullableValue = 0.393420453183973m,
},
            new Decimaldecimal0M
{
    Id = 136,
    Value = 0.552165530811121m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 73,
    Value = 0.930650463079556m,
    NullableValue = 0.41298120238161m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 137,
    Value = 0.315575659059029m,
    ModelInner = null,
    NullableValue = 0.566884221871691m,
},
            new Decimaldecimal0M
{
    Id = 143,
    Value = 0.436406855071643m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 78,
    Value = 0.528289092550772m,
    NullableValue = 0.123133489428101m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 144,
    Value = 0.38644120382761m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 153,
    Value = 0.977043463434832m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 87,
    Value = 0.846292914080618m,
    NullableValue = null,
},
    NullableValue = 0.880645402153523m,
},
            new Decimaldecimal0M
{
    Id = 155,
    Value = 0.338948608472966m,
    ModelInner = null,
    NullableValue = 0.858474097861869m,
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
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
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[23],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[24],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 119;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[23],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Decimaldecimal0M.AssertModel(models[0],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Decimaldecimal0M.AssertModel(models[0],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Decimaldecimal0M.AssertModel(models[0],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Decimaldecimal0M.AssertModel(models[0],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 118, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[34], false);
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 136, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimaldecimal0M.AssertModel(models1[i],_testData[i], false);
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 75, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
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
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[34], false);
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 66, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 143, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[34], false);
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 137, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 66, query1, 55, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[34], false);
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatch(connection, 32, query1, 20, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[26],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Decimaldecimal0M.AssertModel(models[0],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Decimaldecimal0M.AssertModel(models[0],_testData[4], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[5], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[6], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[7], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[8], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[9], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[10], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[11], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[12], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[19],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[20],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[21],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[22],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[23],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[24],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[25],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[26],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[27],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[28],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[29],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[30],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatch(connection, 102, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Decimaldecimal0M.AssertModel(models[0],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Decimaldecimal0M.AssertModel(models[0],_testData[3], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[4], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[5], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[6], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[7], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[8], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[9], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[10], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[11], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[12], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[19],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[20],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[21],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[22],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[23],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[24],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[25],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[26],_testData[29], false);
                        Decimaldecimal0M.AssertModel(models[27],_testData[30], false);
                        Decimaldecimal0M.AssertModel(models[28],_testData[31], false);
                        Decimaldecimal0M.AssertModel(models[29],_testData[32], false);
                        Decimaldecimal0M.AssertModel(models[30],_testData[33], false);
                        Decimaldecimal0M.AssertModel(models[31],_testData[34], false);
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
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models = await ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                Decimaldecimal0M.AssertModel(models[0],_testData[15], false);
                Decimaldecimal0M.AssertModel(models[1],_testData[16], false);
                Decimaldecimal0M.AssertModel(models[2],_testData[17], false);
                Decimaldecimal0M.AssertModel(models[3],_testData[18], false);
                Decimaldecimal0M.AssertModel(models[4],_testData[19], false);
                Decimaldecimal0M.AssertModel(models[5],_testData[20], false);
                Decimaldecimal0M.AssertModel(models[6],_testData[21], false);
                Decimaldecimal0M.AssertModel(models[7],_testData[22], false);
                Decimaldecimal0M.AssertModel(models[8],_testData[23], false);
                Decimaldecimal0M.AssertModel(models[9],_testData[24], false);
                Decimaldecimal0M.AssertModel(models[10],_testData[25], false);
                Decimaldecimal0M.AssertModel(models[11],_testData[26], false);
                Decimaldecimal0M.AssertModel(models[12],_testData[27], false);
                Decimaldecimal0M.AssertModel(models[13],_testData[28], false);
                Decimaldecimal0M.AssertModel(models[14],_testData[29], false);
                Decimaldecimal0M.AssertModel(models[15],_testData[30], false);
                Decimaldecimal0M.AssertModel(models[16],_testData[31], false);
                Decimaldecimal0M.AssertModel(models[17],_testData[32], false);
                Decimaldecimal0M.AssertModel(models[18],_testData[33], false);
                Decimaldecimal0M.AssertModel(models[19],_testData[34], false);
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
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.140506141211336m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.582655216745095m)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.642273143752188m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.498964385283055m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0286965115313702m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.369675500416226m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.1808565369817m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.589558892999476m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.237315203619751m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.329238429980515m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.898256706449057m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.151468212982475m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.5789407655616m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.998705791341387m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.54855052256165m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.602482141724418m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.452482691025082m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0867527385921176m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.692836781414428m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0330941581241571m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.315575964030449m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.846858823865876m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0987729931843066m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.2422397499318m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.367377278847006m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.719529168898787m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.344088073095766m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.227301511241147m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.739994504291812m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.864972679203538m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.272137316137535m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0990938440531454m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.339739643555933m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.257466976654479m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0461254848637971m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0436775854103222m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.446997031391994m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.381098419280187m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.526145713486374m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0556560845518792m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.279811083792311m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.166026846574995m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.758808743679701m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.768949703572091m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.92309283368253m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.390467966014666m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.980847561524872m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.411011381495688m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0175838147737823m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.501932019627641m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.914070858144056m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.521925971827356m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.39041368219921m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.705271085030391m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.875898669328773m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.51483616694524m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.532986089209665m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.664151760340581m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.531316415755868m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.6672177662919m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.664338464102833m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.460862074925814m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.440082511334004m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.374024115159566m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.393420453183973m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.552165530811121m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.930650463079556m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.41298120238161m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.315575659059029m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.566884221871691m)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.436406855071643m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.528289092550772m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.123133489428101m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.38644120382761m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.977043463434832m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.846292914080618m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.880645402153523m)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.338948608472966m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.858474097861869m)));

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
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.140506141211336m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.582655216745095m)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.642273143752188m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.498964385283055m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.0286965115313702m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.369675500416226m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.1808565369817m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.589558892999476m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.237315203619751m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.329238429980515m)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.898256706449057m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.151468212982475m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.5789407655616m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.998705791341387m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.54855052256165m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.602482141724418m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.452482691025082m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0867527385921176m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.692836781414428m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0330941581241571m)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.315575964030449m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.846858823865876m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0987729931843066m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.2422397499318m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.367377278847006m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.719529168898787m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.344088073095766m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.227301511241147m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.739994504291812m)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.864972679203538m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.272137316137535m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0990938440531454m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.339739643555933m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.257466976654479m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0461254848637971m)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0436775854103222m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.446997031391994m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.381098419280187m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.526145713486374m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0556560845518792m)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.279811083792311m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.166026846574995m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.758808743679701m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.768949703572091m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.92309283368253m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.390467966014666m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.980847561524872m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.411011381495688m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0175838147737823m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.501932019627641m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.914070858144056m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.521925971827356m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.39041368219921m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.705271085030391m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.875898669328773m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.51483616694524m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.532986089209665m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.664151760340581m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.531316415755868m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.6672177662919m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.664338464102833m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.460862074925814m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.440082511334004m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.374024115159566m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.393420453183973m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.552165530811121m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.930650463079556m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.41298120238161m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.315575659059029m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.566884221871691m)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.436406855071643m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.528289092550772m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.123133489428101m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.38644120382761m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.977043463434832m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.846292914080618m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.880645402153523m)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.338948608472966m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.858474097861869m)));

            }
        }

#endregion

    }
}

