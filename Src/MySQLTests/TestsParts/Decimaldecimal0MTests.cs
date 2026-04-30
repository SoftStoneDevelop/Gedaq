

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
    Id = 9,
    Value = 0.32631017018818m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 10,
    Value = 0.886509129486153m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 9,
    Value = 0.219225968713063m,
    NullableValue = 0.794310343234892m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 18,
    Value = 0.0814622018817021m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 21,
    Value = 0.803689692168531m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 14,
    Value = 0.901283715171429m,
    NullableValue = 0.716765733398136m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 24,
    Value = 0.240842680134214m,
    ModelInner = null,
    NullableValue = 0.295799384691738m,
},
            new Decimaldecimal0M
{
    Id = 27,
    Value = 0.406975747915472m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 18,
    Value = 0.645220869499808m,
    NullableValue = 0.367243762946689m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 28,
    Value = 0.956871075378702m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 35,
    Value = 0.114749188891425m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 20,
    Value = 0.639506215473417m,
    NullableValue = 0.204153540782091m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 43,
    Value = 0.703884455229283m,
    ModelInner = null,
    NullableValue = 0.375675884338266m,
},
            new Decimaldecimal0M
{
    Id = 51,
    Value = 0.0518421328352557m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 24,
    Value = 0.457026858156379m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 55,
    Value = 0.499610866809304m,
    ModelInner = null,
    NullableValue = 0.360000595546774m,
},
            new Decimaldecimal0M
{
    Id = 56,
    Value = 0.349179257615678m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 31,
    Value = 0.364225591821109m,
    NullableValue = 0.52645969990846m,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 61,
    Value = 0.344265401547745m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 65,
    Value = 0.492304009085753m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 34,
    Value = 0.343145766200285m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 70,
    Value = 0.67985036498356m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 79,
    Value = 0.192165249987448m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 35,
    Value = 0.10511955203508m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 86,
    Value = 0.314502245631364m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 89,
    Value = 0.913148647194495m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 36,
    Value = 0.327679088473111m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 95,
    Value = 0.059081032094877m,
    ModelInner = null,
    NullableValue = 0.0327870571431794m,
},
            new Decimaldecimal0M
{
    Id = 104,
    Value = 0.542396224254633m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 42,
    Value = 0.604037021478766m,
    NullableValue = null,
},
    NullableValue = 0.991507225900274m,
},
            new Decimaldecimal0M
{
    Id = 110,
    Value = 0.685744464898256m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 115,
    Value = 0.275619491107305m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 51,
    Value = 0.195874396825663m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 121,
    Value = 0.595947483683814m,
    ModelInner = null,
    NullableValue = 0.779442791867012m,
},
            new Decimaldecimal0M
{
    Id = 127,
    Value = 0.993263939764535m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 60,
    Value = 0.0370336835948815m,
    NullableValue = null,
},
    NullableValue = 0.893587494489007m,
},
            new Decimaldecimal0M
{
    Id = 133,
    Value = 0.771430556668145m,
    ModelInner = null,
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 138,
    Value = 0.539089078896112m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 66,
    Value = 0.76136687997095m,
    NullableValue = null,
},
    NullableValue = null,
},
            new Decimaldecimal0M
{
    Id = 144,
    Value = 0.530937838994556m,
    ModelInner = null,
    NullableValue = 0.613625752102382m,
},
            new Decimaldecimal0M
{
    Id = 145,
    Value = 0.21973329152587m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 70,
    Value = 0.740113227009896m,
    NullableValue = null,
},
    NullableValue = 0.0461830364085133m,
},
            new Decimaldecimal0M
{
    Id = 154,
    Value = 0.620602546321735m,
    ModelInner = null,
    NullableValue = 0.703601664041772m,
},
            new Decimaldecimal0M
{
    Id = 163,
    Value = 0.451916061040414m,
    ModelInner = new Decimaldecimal0MI
{
    Id = 76,
    Value = 0.941737335266868m,
    NullableValue = null,
},
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IDecimalSingleTypedecimal)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
FROM gedaqtests.decimaldecimal0m m
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
FROM gedaqtests.decimaldecimal0m m
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[29], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[29], false);
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
                parametr2.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
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
                parametr1.Value = 21;
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[23],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[24],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[29], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 144;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Decimaldecimal0M.AssertModel(models[0],_testData[6], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[7], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[8], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[9], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[10], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[11], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[12], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[19],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[20],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[21],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[22],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Decimaldecimal0M.AssertModel(models[0],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[29], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Decimaldecimal0M.AssertModel(models[0],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[29], false);
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 56, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
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
                await ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 121, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[29], false);
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 9, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 70, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDecimaldecimal0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[28],_testData[29], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 28, query1, 27, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimaldecimal0M.AssertModel(models[0],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(models[1],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(models[2],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(models[3],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(models[4],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(models[5],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(models[6],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(models[7],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(models[8],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(models[9],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(models[10],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(models[11],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(models[12],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(models[13],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(models[14],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(models[15],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(models[16],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(models[17],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(models[18],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(models[19],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(models[20],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(models[21],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                await ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 95, query1, 10, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[27],_testData[29], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 79, query1, 79, query2))
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
                 ((IDecimalSingleTypedecimal)this).DbConnectionDynQuerySelectModelBatch(connection, 55, query1, 10, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimaldecimal0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimaldecimal0M.AssertModel(secondItems2[27],_testData[29], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatchAsync(connection, 35, 144))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Decimaldecimal0M.AssertModel(models[0],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[29], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypedecimal)this).DbConnectionSTSelectModelBatch(connection, 21, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Decimaldecimal0M.AssertModel(models[0],_testData[9], false);
                        Decimaldecimal0M.AssertModel(models[1],_testData[10], false);
                        Decimaldecimal0M.AssertModel(models[2],_testData[11], false);
                        Decimaldecimal0M.AssertModel(models[3],_testData[12], false);
                        Decimaldecimal0M.AssertModel(models[4],_testData[13], false);
                        Decimaldecimal0M.AssertModel(models[5],_testData[14], false);
                        Decimaldecimal0M.AssertModel(models[6],_testData[15], false);
                        Decimaldecimal0M.AssertModel(models[7],_testData[16], false);
                        Decimaldecimal0M.AssertModel(models[8],_testData[17], false);
                        Decimaldecimal0M.AssertModel(models[9],_testData[18], false);
                        Decimaldecimal0M.AssertModel(models[10],_testData[19], false);
                        Decimaldecimal0M.AssertModel(models[11],_testData[20], false);
                        Decimaldecimal0M.AssertModel(models[12],_testData[21], false);
                        Decimaldecimal0M.AssertModel(models[13],_testData[22], false);
                        Decimaldecimal0M.AssertModel(models[14],_testData[23], false);
                        Decimaldecimal0M.AssertModel(models[15],_testData[24], false);
                        Decimaldecimal0M.AssertModel(models[16],_testData[25], false);
                        Decimaldecimal0M.AssertModel(models[17],_testData[26], false);
                        Decimaldecimal0M.AssertModel(models[18],_testData[27], false);
                        Decimaldecimal0M.AssertModel(models[19],_testData[28], false);
                        Decimaldecimal0M.AssertModel(models[20],_testData[29], false);
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
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 145);
                var models = await ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Decimaldecimal0M.AssertModel(models[0],_testData[28], false);Decimaldecimal0M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypedecimal)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypedecimal)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models =  ((IDecimalSingleTypedecimal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
Decimaldecimal0M.AssertModel(models[0],_testData[19], false);Decimaldecimal0M.AssertModel(models[1],_testData[20], false);Decimaldecimal0M.AssertModel(models[2],_testData[21], false);Decimaldecimal0M.AssertModel(models[3],_testData[22], false);Decimaldecimal0M.AssertModel(models[4],_testData[23], false);Decimaldecimal0M.AssertModel(models[5],_testData[24], false);Decimaldecimal0M.AssertModel(models[6],_testData[25], false);Decimaldecimal0M.AssertModel(models[7],_testData[26], false);Decimaldecimal0M.AssertModel(models[8],_testData[27], false);Decimaldecimal0M.AssertModel(models[9],_testData[28], false);Decimaldecimal0M.AssertModel(models[10],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.32631017018818m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.886509129486153m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.219225968713063m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.794310343234892m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0814622018817021m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.803689692168531m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.901283715171429m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.716765733398136m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.240842680134214m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.295799384691738m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.406975747915472m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.645220869499808m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.367243762946689m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.956871075378702m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.114749188891425m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.639506215473417m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.204153540782091m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.703884455229283m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.375675884338266m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0518421328352557m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.457026858156379m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.499610866809304m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.360000595546774m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.349179257615678m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.364225591821109m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.52645969990846m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.344265401547745m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.492304009085753m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.343145766200285m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.67985036498356m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.192165249987448m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.10511955203508m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.314502245631364m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.913148647194495m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.327679088473111m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.059081032094877m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0327870571431794m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.542396224254633m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.604037021478766m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.991507225900274m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.685744464898256m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.275619491107305m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.195874396825663m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.595947483683814m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.779442791867012m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.993263939764535m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0370336835948815m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.893587494489007m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.771430556668145m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.539089078896112m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.76136687997095m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.530937838994556m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.613625752102382m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.21973329152587m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.740113227009896m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0461830364085133m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.620602546321735m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.703601664041772m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.451916061040414m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.941737335266868m)));//InnerModel.Value

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
                var models =  ((IDecimalSingleTypedecimal)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.32631017018818m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.886509129486153m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.219225968713063m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.794310343234892m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0814622018817021m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.803689692168531m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.901283715171429m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.716765733398136m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.240842680134214m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.295799384691738m)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.406975747915472m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.645220869499808m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.367243762946689m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.956871075378702m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.114749188891425m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.639506215473417m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.204153540782091m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.703884455229283m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.375675884338266m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.0518421328352557m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.457026858156379m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.499610866809304m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.360000595546774m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.349179257615678m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.364225591821109m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.52645969990846m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.344265401547745m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.492304009085753m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.343145766200285m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.67985036498356m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.192165249987448m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.10511955203508m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.314502245631364m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.913148647194495m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.327679088473111m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.059081032094877m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0327870571431794m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.542396224254633m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.604037021478766m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.991507225900274m)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.685744464898256m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.275619491107305m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.195874396825663m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.595947483683814m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.779442791867012m)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.993263939764535m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.0370336835948815m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.893587494489007m)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.771430556668145m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.539089078896112m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.76136687997095m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.530937838994556m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.613625752102382m)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.21973329152587m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.740113227009896m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.0461830364085133m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.620602546321735m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.703601664041772m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.451916061040414m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.941737335266868m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

