

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
    Id = 1,
    Value = 0.23491177412505326d,
    ModelInner = null,
    NullableValue = 0.08867270154419793d,
},
            new Doubledouble0M
{
    Id = 2,
    Value = 0.4555396335265036d,
    ModelInner = new Doubledouble0MI
{
    Id = 1,
    Value = 0.14674331481102154d,
    NullableValue = 0.7725736214669768d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 9,
    Value = 0.9863011235491765d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 10,
    Value = 0.10841332940618698d,
    ModelInner = new Doubledouble0MI
{
    Id = 5,
    Value = 0.4866739328542464d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 12,
    Value = 0.053621114146689686d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 17,
    Value = 0.3261340574538196d,
    ModelInner = new Doubledouble0MI
{
    Id = 6,
    Value = 0.28421081604295784d,
    NullableValue = 0.7238423621005422d,
},
    NullableValue = 0.03305901952130952d,
},
            new Doubledouble0M
{
    Id = 22,
    Value = 0.7603520370550704d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 25,
    Value = 0.9131109266316065d,
    ModelInner = new Doubledouble0MI
{
    Id = 12,
    Value = 0.011317494169014841d,
    NullableValue = null,
},
    NullableValue = 0.811620274484526d,
},
            new Doubledouble0M
{
    Id = 32,
    Value = 0.6481006266139007d,
    ModelInner = null,
    NullableValue = 0.2610844913606407d,
},
            new Doubledouble0M
{
    Id = 33,
    Value = 0.2454996665324416d,
    ModelInner = new Doubledouble0MI
{
    Id = 19,
    Value = 0.6448735383076871d,
    NullableValue = null,
},
    NullableValue = 0.48423632494555824d,
},
            new Doubledouble0M
{
    Id = 38,
    Value = 0.8580193676468094d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 43,
    Value = 0.7796371449920776d,
    ModelInner = new Doubledouble0MI
{
    Id = 22,
    Value = 0.1324433647109493d,
    NullableValue = 0.9350372971429457d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 44,
    Value = 0.0867865423272638d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 45,
    Value = 0.8650483762300056d,
    ModelInner = new Doubledouble0MI
{
    Id = 27,
    Value = 0.5078747630818445d,
    NullableValue = 0.5239816920835618d,
},
    NullableValue = 0.3283096079332316d,
},
            new Doubledouble0M
{
    Id = 54,
    Value = 0.2797881051772192d,
    ModelInner = null,
    NullableValue = 0.007169331090423947d,
},
            new Doubledouble0M
{
    Id = 62,
    Value = 0.30206752153828464d,
    ModelInner = new Doubledouble0MI
{
    Id = 32,
    Value = 0.42456787858260714d,
    NullableValue = null,
},
    NullableValue = 0.7511532239603558d,
},
            new Doubledouble0M
{
    Id = 67,
    Value = 0.7821977714545612d,
    ModelInner = null,
    NullableValue = 0.9086977135901283d,
},
            new Doubledouble0M
{
    Id = 72,
    Value = 0.3788461620818605d,
    ModelInner = new Doubledouble0MI
{
    Id = 35,
    Value = 0.4273722086336038d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 73,
    Value = 0.7157839576852474d,
    ModelInner = null,
    NullableValue = 0.5707788058029386d,
},
            new Doubledouble0M
{
    Id = 77,
    Value = 0.1176927032928885d,
    ModelInner = new Doubledouble0MI
{
    Id = 37,
    Value = 0.9528154108120821d,
    NullableValue = 0.44197154603280775d,
},
    NullableValue = 0.7085553683162242d,
},
            new Doubledouble0M
{
    Id = 81,
    Value = 0.6979915515413688d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 90,
    Value = 0.2667288195038483d,
    ModelInner = new Doubledouble0MI
{
    Id = 38,
    Value = 0.2952963037311386d,
    NullableValue = null,
},
    NullableValue = 0.6758199681559529d,
},
            new Doubledouble0M
{
    Id = 92,
    Value = 0.284835970134965d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 93,
    Value = 0.9578838562102855d,
    ModelInner = new Doubledouble0MI
{
    Id = 39,
    Value = 0.545223121780985d,
    NullableValue = 0.49769712445107184d,
},
    NullableValue = 0.8540461193804212d,
},
            new Doubledouble0M
{
    Id = 97,
    Value = 0.7339729000582856d,
    ModelInner = null,
    NullableValue = 0.5369762695047375d,
},
            new Doubledouble0M
{
    Id = 104,
    Value = 0.05780316664567697d,
    ModelInner = new Doubledouble0MI
{
    Id = 46,
    Value = 0.2464232364099841d,
    NullableValue = 0.29348411985464173d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 112,
    Value = 0.8675997604015236d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 120,
    Value = 0.5059864826590037d,
    ModelInner = new Doubledouble0MI
{
    Id = 48,
    Value = 0.7806759603944355d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 127,
    Value = 0.5959883146014862d,
    ModelInner = null,
    NullableValue = 0.797394924648794d,
},
            new Doubledouble0M
{
    Id = 131,
    Value = 0.6844370792673271d,
    ModelInner = new Doubledouble0MI
{
    Id = 54,
    Value = 0.47028051612196387d,
    NullableValue = 0.9992270438472363d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 135,
    Value = 0.6559869545875088d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 144,
    Value = 0.6399383972371421d,
    ModelInner = new Doubledouble0MI
{
    Id = 60,
    Value = 0.6467791249159204d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 147,
    Value = 0.7873060684490016d,
    ModelInner = null,
    NullableValue = 0.566357775331392d,
},
            new Doubledouble0M
{
    Id = 156,
    Value = 0.7171168225637896d,
    ModelInner = new Doubledouble0MI
{
    Id = 67,
    Value = 0.14944428961415146d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 159,
    Value = 0.053642853584402794d,
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
                parametr1.Value = 25;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[1], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[23],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[24],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[25],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[26],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[27],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[28],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[29],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[30],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[31],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[32],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[23],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[24],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[25],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[26],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[2], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[21],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[22],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[23],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[24],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[25],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[26],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[27],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[28],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[29],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[30],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[31],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[34], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble0M.AssertModel(models[0],_testData[6], false);
                        Doubledouble0M.AssertModel(models[1],_testData[7], false);
                        Doubledouble0M.AssertModel(models[2],_testData[8], false);
                        Doubledouble0M.AssertModel(models[3],_testData[9], false);
                        Doubledouble0M.AssertModel(models[4],_testData[10], false);
                        Doubledouble0M.AssertModel(models[5],_testData[11], false);
                        Doubledouble0M.AssertModel(models[6],_testData[12], false);
                        Doubledouble0M.AssertModel(models[7],_testData[13], false);
                        Doubledouble0M.AssertModel(models[8],_testData[14], false);
                        Doubledouble0M.AssertModel(models[9],_testData[15], false);
                        Doubledouble0M.AssertModel(models[10],_testData[16], false);
                        Doubledouble0M.AssertModel(models[11],_testData[17], false);
                        Doubledouble0M.AssertModel(models[12],_testData[18], false);
                        Doubledouble0M.AssertModel(models[13],_testData[19], false);
                        Doubledouble0M.AssertModel(models[14],_testData[20], false);
                        Doubledouble0M.AssertModel(models[15],_testData[21], false);
                        Doubledouble0M.AssertModel(models[16],_testData[22], false);
                        Doubledouble0M.AssertModel(models[17],_testData[23], false);
                        Doubledouble0M.AssertModel(models[18],_testData[24], false);
                        Doubledouble0M.AssertModel(models[19],_testData[25], false);
                        Doubledouble0M.AssertModel(models[20],_testData[26], false);
                        Doubledouble0M.AssertModel(models[21],_testData[27], false);
                        Doubledouble0M.AssertModel(models[22],_testData[28], false);
                        Doubledouble0M.AssertModel(models[23],_testData[29], false);
                        Doubledouble0M.AssertModel(models[24],_testData[30], false);
                        Doubledouble0M.AssertModel(models[25],_testData[31], false);
                        Doubledouble0M.AssertModel(models[26],_testData[32], false);
                        Doubledouble0M.AssertModel(models[27],_testData[33], false);
                        Doubledouble0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Doubledouble0M.AssertModel(models[0],_testData[15], false);
                        Doubledouble0M.AssertModel(models[1],_testData[16], false);
                        Doubledouble0M.AssertModel(models[2],_testData[17], false);
                        Doubledouble0M.AssertModel(models[3],_testData[18], false);
                        Doubledouble0M.AssertModel(models[4],_testData[19], false);
                        Doubledouble0M.AssertModel(models[5],_testData[20], false);
                        Doubledouble0M.AssertModel(models[6],_testData[21], false);
                        Doubledouble0M.AssertModel(models[7],_testData[22], false);
                        Doubledouble0M.AssertModel(models[8],_testData[23], false);
                        Doubledouble0M.AssertModel(models[9],_testData[24], false);
                        Doubledouble0M.AssertModel(models[10],_testData[25], false);
                        Doubledouble0M.AssertModel(models[11],_testData[26], false);
                        Doubledouble0M.AssertModel(models[12],_testData[27], false);
                        Doubledouble0M.AssertModel(models[13],_testData[28], false);
                        Doubledouble0M.AssertModel(models[14],_testData[29], false);
                        Doubledouble0M.AssertModel(models[15],_testData[30], false);
                        Doubledouble0M.AssertModel(models[16],_testData[31], false);
                        Doubledouble0M.AssertModel(models[17],_testData[32], false);
                        Doubledouble0M.AssertModel(models[18],_testData[33], false);
                        Doubledouble0M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble0M.AssertModel(models[0],_testData[31], false);
                        Doubledouble0M.AssertModel(models[1],_testData[32], false);
                        Doubledouble0M.AssertModel(models[2],_testData[33], false);
                        Doubledouble0M.AssertModel(models[3],_testData[34], false);
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
                await ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 10, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[30],_testData[34], false);
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
                await ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 73, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[34], false);
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
                 ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 45, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[34], false);
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
                 ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 92, query1, 73, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[34], false);
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
                await ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 93, query1, 62, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatch(connection, 12, query1, 72, query2))
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[34], false);
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
                 ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatch(connection, 81, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatchAsync(connection, 9, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Doubledouble0M.AssertModel(models[0],_testData[3], false);
                        Doubledouble0M.AssertModel(models[1],_testData[4], false);
                        Doubledouble0M.AssertModel(models[2],_testData[5], false);
                        Doubledouble0M.AssertModel(models[3],_testData[6], false);
                        Doubledouble0M.AssertModel(models[4],_testData[7], false);
                        Doubledouble0M.AssertModel(models[5],_testData[8], false);
                        Doubledouble0M.AssertModel(models[6],_testData[9], false);
                        Doubledouble0M.AssertModel(models[7],_testData[10], false);
                        Doubledouble0M.AssertModel(models[8],_testData[11], false);
                        Doubledouble0M.AssertModel(models[9],_testData[12], false);
                        Doubledouble0M.AssertModel(models[10],_testData[13], false);
                        Doubledouble0M.AssertModel(models[11],_testData[14], false);
                        Doubledouble0M.AssertModel(models[12],_testData[15], false);
                        Doubledouble0M.AssertModel(models[13],_testData[16], false);
                        Doubledouble0M.AssertModel(models[14],_testData[17], false);
                        Doubledouble0M.AssertModel(models[15],_testData[18], false);
                        Doubledouble0M.AssertModel(models[16],_testData[19], false);
                        Doubledouble0M.AssertModel(models[17],_testData[20], false);
                        Doubledouble0M.AssertModel(models[18],_testData[21], false);
                        Doubledouble0M.AssertModel(models[19],_testData[22], false);
                        Doubledouble0M.AssertModel(models[20],_testData[23], false);
                        Doubledouble0M.AssertModel(models[21],_testData[24], false);
                        Doubledouble0M.AssertModel(models[22],_testData[25], false);
                        Doubledouble0M.AssertModel(models[23],_testData[26], false);
                        Doubledouble0M.AssertModel(models[24],_testData[27], false);
                        Doubledouble0M.AssertModel(models[25],_testData[28], false);
                        Doubledouble0M.AssertModel(models[26],_testData[29], false);
                        Doubledouble0M.AssertModel(models[27],_testData[30], false);
                        Doubledouble0M.AssertModel(models[28],_testData[31], false);
                        Doubledouble0M.AssertModel(models[29],_testData[32], false);
                        Doubledouble0M.AssertModel(models[30],_testData[33], false);
                        Doubledouble0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Doubledouble0M.AssertModel(models[0],_testData[12], false);
                        Doubledouble0M.AssertModel(models[1],_testData[13], false);
                        Doubledouble0M.AssertModel(models[2],_testData[14], false);
                        Doubledouble0M.AssertModel(models[3],_testData[15], false);
                        Doubledouble0M.AssertModel(models[4],_testData[16], false);
                        Doubledouble0M.AssertModel(models[5],_testData[17], false);
                        Doubledouble0M.AssertModel(models[6],_testData[18], false);
                        Doubledouble0M.AssertModel(models[7],_testData[19], false);
                        Doubledouble0M.AssertModel(models[8],_testData[20], false);
                        Doubledouble0M.AssertModel(models[9],_testData[21], false);
                        Doubledouble0M.AssertModel(models[10],_testData[22], false);
                        Doubledouble0M.AssertModel(models[11],_testData[23], false);
                        Doubledouble0M.AssertModel(models[12],_testData[24], false);
                        Doubledouble0M.AssertModel(models[13],_testData[25], false);
                        Doubledouble0M.AssertModel(models[14],_testData[26], false);
                        Doubledouble0M.AssertModel(models[15],_testData[27], false);
                        Doubledouble0M.AssertModel(models[16],_testData[28], false);
                        Doubledouble0M.AssertModel(models[17],_testData[29], false);
                        Doubledouble0M.AssertModel(models[18],_testData[30], false);
                        Doubledouble0M.AssertModel(models[19],_testData[31], false);
                        Doubledouble0M.AssertModel(models[20],_testData[32], false);
                        Doubledouble0M.AssertModel(models[21],_testData[33], false);
                        Doubledouble0M.AssertModel(models[22],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatch(connection, 62, 43))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Doubledouble0M.AssertModel(models[0],_testData[12], false);
                        Doubledouble0M.AssertModel(models[1],_testData[13], false);
                        Doubledouble0M.AssertModel(models[2],_testData[14], false);
                        Doubledouble0M.AssertModel(models[3],_testData[15], false);
                        Doubledouble0M.AssertModel(models[4],_testData[16], false);
                        Doubledouble0M.AssertModel(models[5],_testData[17], false);
                        Doubledouble0M.AssertModel(models[6],_testData[18], false);
                        Doubledouble0M.AssertModel(models[7],_testData[19], false);
                        Doubledouble0M.AssertModel(models[8],_testData[20], false);
                        Doubledouble0M.AssertModel(models[9],_testData[21], false);
                        Doubledouble0M.AssertModel(models[10],_testData[22], false);
                        Doubledouble0M.AssertModel(models[11],_testData[23], false);
                        Doubledouble0M.AssertModel(models[12],_testData[24], false);
                        Doubledouble0M.AssertModel(models[13],_testData[25], false);
                        Doubledouble0M.AssertModel(models[14],_testData[26], false);
                        Doubledouble0M.AssertModel(models[15],_testData[27], false);
                        Doubledouble0M.AssertModel(models[16],_testData[28], false);
                        Doubledouble0M.AssertModel(models[17],_testData[29], false);
                        Doubledouble0M.AssertModel(models[18],_testData[30], false);
                        Doubledouble0M.AssertModel(models[19],_testData[31], false);
                        Doubledouble0M.AssertModel(models[20],_testData[32], false);
                        Doubledouble0M.AssertModel(models[21],_testData[33], false);
                        Doubledouble0M.AssertModel(models[22],_testData[34], false);
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
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models = await ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                Doubledouble0M.AssertModel(models[0],_testData[27], false);
                Doubledouble0M.AssertModel(models[1],_testData[28], false);
                Doubledouble0M.AssertModel(models[2],_testData[29], false);
                Doubledouble0M.AssertModel(models[3],_testData[30], false);
                Doubledouble0M.AssertModel(models[4],_testData[31], false);
                Doubledouble0M.AssertModel(models[5],_testData[32], false);
                Doubledouble0M.AssertModel(models[6],_testData[33], false);
                Doubledouble0M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypedouble)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 127);
                var models =  ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                Doubledouble0M.AssertModel(models[0],_testData[29], false);
                Doubledouble0M.AssertModel(models[1],_testData[30], false);
                Doubledouble0M.AssertModel(models[2],_testData[31], false);
                Doubledouble0M.AssertModel(models[3],_testData[32], false);
                Doubledouble0M.AssertModel(models[4],_testData[33], false);
                Doubledouble0M.AssertModel(models[5],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.23491177412505326d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.08867270154419793d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4555396335265036d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.14674331481102154d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7725736214669768d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9863011235491765d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10841332940618698d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4866739328542464d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.053621114146689686d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3261340574538196d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.28421081604295784d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7238423621005422d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.03305901952130952d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7603520370550704d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9131109266316065d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.011317494169014841d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.811620274484526d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6481006266139007d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2610844913606407d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2454996665324416d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6448735383076871d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.48423632494555824d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8580193676468094d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7796371449920776d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1324433647109493d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9350372971429457d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.0867865423272638d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8650483762300056d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5078747630818445d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5239816920835618d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3283096079332316d)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2797881051772192d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.007169331090423947d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.30206752153828464d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.42456787858260714d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7511532239603558d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7821977714545612d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9086977135901283d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3788461620818605d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4273722086336038d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7157839576852474d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5707788058029386d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1176927032928885d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9528154108120821d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.44197154603280775d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7085553683162242d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6979915515413688d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2667288195038483d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2952963037311386d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6758199681559529d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.284835970134965d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9578838562102855d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.545223121780985d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.49769712445107184d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8540461193804212d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7339729000582856d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5369762695047375d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05780316664567697d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2464232364099841d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.29348411985464173d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8675997604015236d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5059864826590037d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7806759603944355d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5959883146014862d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.797394924648794d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6844370792673271d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.47028051612196387d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9992270438472363d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6559869545875088d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6399383972371421d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6467791249159204d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7873060684490016d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.566357775331392d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7171168225637896d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.14944428961415146d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.053642853584402794d)));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.23491177412505326d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.08867270154419793d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4555396335265036d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.14674331481102154d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7725736214669768d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9863011235491765d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10841332940618698d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4866739328542464d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.053621114146689686d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3261340574538196d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.28421081604295784d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7238423621005422d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.03305901952130952d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7603520370550704d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9131109266316065d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.011317494169014841d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.811620274484526d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6481006266139007d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2610844913606407d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2454996665324416d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6448735383076871d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.48423632494555824d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8580193676468094d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7796371449920776d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1324433647109493d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9350372971429457d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.0867865423272638d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8650483762300056d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5078747630818445d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.5239816920835618d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3283096079332316d)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2797881051772192d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.007169331090423947d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.30206752153828464d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.42456787858260714d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7511532239603558d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7821977714545612d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9086977135901283d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3788461620818605d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4273722086336038d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7157839576852474d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5707788058029386d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1176927032928885d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9528154108120821d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.44197154603280775d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7085553683162242d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6979915515413688d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2667288195038483d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2952963037311386d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6758199681559529d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.284835970134965d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9578838562102855d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.545223121780985d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.49769712445107184d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8540461193804212d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7339729000582856d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5369762695047375d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.05780316664567697d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2464232364099841d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.29348411985464173d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8675997604015236d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5059864826590037d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7806759603944355d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5959883146014862d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.797394924648794d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6844370792673271d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.47028051612196387d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9992270438472363d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6559869545875088d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6399383972371421d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6467791249159204d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7873060684490016d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.566357775331392d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7171168225637896d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.14944428961415146d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.053642853584402794d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

