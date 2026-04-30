

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
    Id = 2,
    Value = 0.9873999463780074d,
    ModelInner = null,
    NullableValue = 0.40005401285299313d,
},
            new Doubledouble0M
{
    Id = 5,
    Value = 0.6686100576833589d,
    ModelInner = new Doubledouble0MI
{
    Id = 8,
    Value = 0.7392361366093083d,
    NullableValue = 0.6625871135435683d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 7,
    Value = 0.06354218638421472d,
    ModelInner = null,
    NullableValue = 0.3188873185569653d,
},
            new Doubledouble0M
{
    Id = 15,
    Value = 0.14770998625782528d,
    ModelInner = new Doubledouble0MI
{
    Id = 13,
    Value = 0.908308734862411d,
    NullableValue = 0.6972496513672712d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 19,
    Value = 0.3909202205485046d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 21,
    Value = 0.9278079580475035d,
    ModelInner = new Doubledouble0MI
{
    Id = 17,
    Value = 0.889966157079392d,
    NullableValue = 0.37968263809239433d,
},
    NullableValue = 0.6635200408577636d,
},
            new Doubledouble0M
{
    Id = 23,
    Value = 0.5549943819394361d,
    ModelInner = null,
    NullableValue = 0.5049089390684821d,
},
            new Doubledouble0M
{
    Id = 29,
    Value = 0.8406702219370469d,
    ModelInner = new Doubledouble0MI
{
    Id = 21,
    Value = 0.8367010403259668d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 38,
    Value = 0.6972780119690164d,
    ModelInner = null,
    NullableValue = 0.02154161374883634d,
},
            new Doubledouble0M
{
    Id = 40,
    Value = 0.6205145231895781d,
    ModelInner = new Doubledouble0MI
{
    Id = 29,
    Value = 0.19336247998719125d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 46,
    Value = 0.8495128591120378d,
    ModelInner = null,
    NullableValue = 0.6405931350929781d,
},
            new Doubledouble0M
{
    Id = 54,
    Value = 0.3085578388507625d,
    ModelInner = new Doubledouble0MI
{
    Id = 30,
    Value = 0.37908984045002436d,
    NullableValue = 0.8767207779034873d,
},
    NullableValue = 0.7843191984118333d,
},
            new Doubledouble0M
{
    Id = 61,
    Value = 0.8428991858335863d,
    ModelInner = null,
    NullableValue = 0.12657015658650161d,
},
            new Doubledouble0M
{
    Id = 68,
    Value = 0.8775139016923541d,
    ModelInner = new Doubledouble0MI
{
    Id = 32,
    Value = 0.9814076585901886d,
    NullableValue = 0.9585026011177054d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 74,
    Value = 0.2788036729528548d,
    ModelInner = null,
    NullableValue = 0.2648547177182038d,
},
            new Doubledouble0M
{
    Id = 76,
    Value = 0.9977417853189705d,
    ModelInner = new Doubledouble0MI
{
    Id = 39,
    Value = 0.2032764632465096d,
    NullableValue = 0.9487653950369814d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 79,
    Value = 0.8066286546468199d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 81,
    Value = 0.4425763940189793d,
    ModelInner = new Doubledouble0MI
{
    Id = 45,
    Value = 0.4597185397773069d,
    NullableValue = null,
},
    NullableValue = 0.7141394516068837d,
},
            new Doubledouble0M
{
    Id = 89,
    Value = 0.6371517912287459d,
    ModelInner = null,
    NullableValue = 0.18038665386685104d,
},
            new Doubledouble0M
{
    Id = 98,
    Value = 0.5798942831789303d,
    ModelInner = new Doubledouble0MI
{
    Id = 48,
    Value = 0.11020349401519969d,
    NullableValue = null,
},
    NullableValue = 0.27814592375789227d,
},
            new Doubledouble0M
{
    Id = 103,
    Value = 0.8948685903155079d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 104,
    Value = 0.17644498411902898d,
    ModelInner = new Doubledouble0MI
{
    Id = 57,
    Value = 0.4350771697775061d,
    NullableValue = null,
},
    NullableValue = 0.25470252581285857d,
},
            new Doubledouble0M
{
    Id = 108,
    Value = 0.4100061236927609d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 114,
    Value = 0.5529162681734514d,
    ModelInner = new Doubledouble0MI
{
    Id = 60,
    Value = 0.860812512930953d,
    NullableValue = null,
},
    NullableValue = 0.10747284459603657d,
},
            new Doubledouble0M
{
    Id = 117,
    Value = 0.4205854326978514d,
    ModelInner = null,
    NullableValue = 0.374025623920916d,
},
            new Doubledouble0M
{
    Id = 122,
    Value = 0.7662040896933204d,
    ModelInner = new Doubledouble0MI
{
    Id = 61,
    Value = 0.6632631342958567d,
    NullableValue = 0.47591158273788314d,
},
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 125,
    Value = 0.8099814547250488d,
    ModelInner = null,
    NullableValue = 0.7158105774146418d,
},
            new Doubledouble0M
{
    Id = 131,
    Value = 0.813708608900775d,
    ModelInner = new Doubledouble0MI
{
    Id = 66,
    Value = 0.7990648801057982d,
    NullableValue = 0.329286223605035d,
},
    NullableValue = 0.5321874899858735d,
},
            new Doubledouble0M
{
    Id = 140,
    Value = 0.947937117640432d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble0M
{
    Id = 141,
    Value = 0.6359479812179459d,
    ModelInner = new Doubledouble0MI
{
    Id = 71,
    Value = 0.267012862956749d,
    NullableValue = null,
},
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 21;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 108;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                parametr2.Value = 108;
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
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble0M.AssertModel(models[0],_testData[28], false);
                        Doubledouble0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble0M.AssertModel(models[0],_testData[11], false);
                        Doubledouble0M.AssertModel(models[1],_testData[12], false);
                        Doubledouble0M.AssertModel(models[2],_testData[13], false);
                        Doubledouble0M.AssertModel(models[3],_testData[14], false);
                        Doubledouble0M.AssertModel(models[4],_testData[15], false);
                        Doubledouble0M.AssertModel(models[5],_testData[16], false);
                        Doubledouble0M.AssertModel(models[6],_testData[17], false);
                        Doubledouble0M.AssertModel(models[7],_testData[18], false);
                        Doubledouble0M.AssertModel(models[8],_testData[19], false);
                        Doubledouble0M.AssertModel(models[9],_testData[20], false);
                        Doubledouble0M.AssertModel(models[10],_testData[21], false);
                        Doubledouble0M.AssertModel(models[11],_testData[22], false);
                        Doubledouble0M.AssertModel(models[12],_testData[23], false);
                        Doubledouble0M.AssertModel(models[13],_testData[24], false);
                        Doubledouble0M.AssertModel(models[14],_testData[25], false);
                        Doubledouble0M.AssertModel(models[15],_testData[26], false);
                        Doubledouble0M.AssertModel(models[16],_testData[27], false);
                        Doubledouble0M.AssertModel(models[17],_testData[28], false);
                        Doubledouble0M.AssertModel(models[18],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 117, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[29], false);
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
                await ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 5, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 89, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[29], false);
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
                 ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatch(connection, 108, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 19, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[20],_testData[29], false);
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
                await ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 122, query1, 114, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatch(connection, 98, query1, 131, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(models[2],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(models[3],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(models[4],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(models[5],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(models[6],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(models[7],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(models[8],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble0M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(models[1],_testData[29], false);
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
                 ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatch(connection, 7, query1, 40, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDoubledouble0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble0M.AssertModel(secondItems2[19],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatchAsync(connection, 103, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble0M.AssertModel(models[0],_testData[21], false);
                        Doubledouble0M.AssertModel(models[1],_testData[22], false);
                        Doubledouble0M.AssertModel(models[2],_testData[23], false);
                        Doubledouble0M.AssertModel(models[3],_testData[24], false);
                        Doubledouble0M.AssertModel(models[4],_testData[25], false);
                        Doubledouble0M.AssertModel(models[5],_testData[26], false);
                        Doubledouble0M.AssertModel(models[6],_testData[27], false);
                        Doubledouble0M.AssertModel(models[7],_testData[28], false);
                        Doubledouble0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Doubledouble0M.AssertModel(models[0],_testData[9], false);
                        Doubledouble0M.AssertModel(models[1],_testData[10], false);
                        Doubledouble0M.AssertModel(models[2],_testData[11], false);
                        Doubledouble0M.AssertModel(models[3],_testData[12], false);
                        Doubledouble0M.AssertModel(models[4],_testData[13], false);
                        Doubledouble0M.AssertModel(models[5],_testData[14], false);
                        Doubledouble0M.AssertModel(models[6],_testData[15], false);
                        Doubledouble0M.AssertModel(models[7],_testData[16], false);
                        Doubledouble0M.AssertModel(models[8],_testData[17], false);
                        Doubledouble0M.AssertModel(models[9],_testData[18], false);
                        Doubledouble0M.AssertModel(models[10],_testData[19], false);
                        Doubledouble0M.AssertModel(models[11],_testData[20], false);
                        Doubledouble0M.AssertModel(models[12],_testData[21], false);
                        Doubledouble0M.AssertModel(models[13],_testData[22], false);
                        Doubledouble0M.AssertModel(models[14],_testData[23], false);
                        Doubledouble0M.AssertModel(models[15],_testData[24], false);
                        Doubledouble0M.AssertModel(models[16],_testData[25], false);
                        Doubledouble0M.AssertModel(models[17],_testData[26], false);
                        Doubledouble0M.AssertModel(models[18],_testData[27], false);
                        Doubledouble0M.AssertModel(models[19],_testData[28], false);
                        Doubledouble0M.AssertModel(models[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatch(connection, 40, 104))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Doubledouble0M.AssertModel(models[0],_testData[10], false);
                        Doubledouble0M.AssertModel(models[1],_testData[11], false);
                        Doubledouble0M.AssertModel(models[2],_testData[12], false);
                        Doubledouble0M.AssertModel(models[3],_testData[13], false);
                        Doubledouble0M.AssertModel(models[4],_testData[14], false);
                        Doubledouble0M.AssertModel(models[5],_testData[15], false);
                        Doubledouble0M.AssertModel(models[6],_testData[16], false);
                        Doubledouble0M.AssertModel(models[7],_testData[17], false);
                        Doubledouble0M.AssertModel(models[8],_testData[18], false);
                        Doubledouble0M.AssertModel(models[9],_testData[19], false);
                        Doubledouble0M.AssertModel(models[10],_testData[20], false);
                        Doubledouble0M.AssertModel(models[11],_testData[21], false);
                        Doubledouble0M.AssertModel(models[12],_testData[22], false);
                        Doubledouble0M.AssertModel(models[13],_testData[23], false);
                        Doubledouble0M.AssertModel(models[14],_testData[24], false);
                        Doubledouble0M.AssertModel(models[15],_testData[25], false);
                        Doubledouble0M.AssertModel(models[16],_testData[26], false);
                        Doubledouble0M.AssertModel(models[17],_testData[27], false);
                        Doubledouble0M.AssertModel(models[18],_testData[28], false);
                        Doubledouble0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble0M.AssertModel(models[0],_testData[22], false);
                        Doubledouble0M.AssertModel(models[1],_testData[23], false);
                        Doubledouble0M.AssertModel(models[2],_testData[24], false);
                        Doubledouble0M.AssertModel(models[3],_testData[25], false);
                        Doubledouble0M.AssertModel(models[4],_testData[26], false);
                        Doubledouble0M.AssertModel(models[5],_testData[27], false);
                        Doubledouble0M.AssertModel(models[6],_testData[28], false);
                        Doubledouble0M.AssertModel(models[7],_testData[29], false);
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
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models = await ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
Doubledouble0M.AssertModel(models[0],_testData[3], false);Doubledouble0M.AssertModel(models[1],_testData[4], false);Doubledouble0M.AssertModel(models[2],_testData[5], false);Doubledouble0M.AssertModel(models[3],_testData[6], false);Doubledouble0M.AssertModel(models[4],_testData[7], false);Doubledouble0M.AssertModel(models[5],_testData[8], false);Doubledouble0M.AssertModel(models[6],_testData[9], false);Doubledouble0M.AssertModel(models[7],_testData[10], false);Doubledouble0M.AssertModel(models[8],_testData[11], false);Doubledouble0M.AssertModel(models[9],_testData[12], false);Doubledouble0M.AssertModel(models[10],_testData[13], false);Doubledouble0M.AssertModel(models[11],_testData[14], false);Doubledouble0M.AssertModel(models[12],_testData[15], false);Doubledouble0M.AssertModel(models[13],_testData[16], false);Doubledouble0M.AssertModel(models[14],_testData[17], false);Doubledouble0M.AssertModel(models[15],_testData[18], false);Doubledouble0M.AssertModel(models[16],_testData[19], false);Doubledouble0M.AssertModel(models[17],_testData[20], false);Doubledouble0M.AssertModel(models[18],_testData[21], false);Doubledouble0M.AssertModel(models[19],_testData[22], false);Doubledouble0M.AssertModel(models[20],_testData[23], false);Doubledouble0M.AssertModel(models[21],_testData[24], false);Doubledouble0M.AssertModel(models[22],_testData[25], false);Doubledouble0M.AssertModel(models[23],_testData[26], false);Doubledouble0M.AssertModel(models[24],_testData[27], false);Doubledouble0M.AssertModel(models[25],_testData[28], false);Doubledouble0M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypedouble)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models =  ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
Doubledouble0M.AssertModel(models[0],_testData[12], false);Doubledouble0M.AssertModel(models[1],_testData[13], false);Doubledouble0M.AssertModel(models[2],_testData[14], false);Doubledouble0M.AssertModel(models[3],_testData[15], false);Doubledouble0M.AssertModel(models[4],_testData[16], false);Doubledouble0M.AssertModel(models[5],_testData[17], false);Doubledouble0M.AssertModel(models[6],_testData[18], false);Doubledouble0M.AssertModel(models[7],_testData[19], false);Doubledouble0M.AssertModel(models[8],_testData[20], false);Doubledouble0M.AssertModel(models[9],_testData[21], false);Doubledouble0M.AssertModel(models[10],_testData[22], false);Doubledouble0M.AssertModel(models[11],_testData[23], false);Doubledouble0M.AssertModel(models[12],_testData[24], false);Doubledouble0M.AssertModel(models[13],_testData[25], false);Doubledouble0M.AssertModel(models[14],_testData[26], false);Doubledouble0M.AssertModel(models[15],_testData[27], false);Doubledouble0M.AssertModel(models[16],_testData[28], false);Doubledouble0M.AssertModel(models[17],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9873999463780074d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.40005401285299313d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6686100576833589d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7392361366093083d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6625871135435683d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.06354218638421472d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3188873185569653d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14770998625782528d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.908308734862411d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6972496513672712d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3909202205485046d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9278079580475035d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.889966157079392d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.37968263809239433d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6635200408577636d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5549943819394361d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5049089390684821d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8406702219370469d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8367010403259668d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6972780119690164d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.02154161374883634d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6205145231895781d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.19336247998719125d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8495128591120378d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6405931350929781d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3085578388507625d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.37908984045002436d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8767207779034873d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7843191984118333d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8428991858335863d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.12657015658650161d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8775139016923541d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9814076585901886d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9585026011177054d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2788036729528548d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2648547177182038d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9977417853189705d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2032764632465096d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9487653950369814d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8066286546468199d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4425763940189793d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4597185397773069d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7141394516068837d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6371517912287459d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.18038665386685104d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5798942831789303d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11020349401519969d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.27814592375789227d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8948685903155079d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17644498411902898d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4350771697775061d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.25470252581285857d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4100061236927609d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5529162681734514d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.860812512930953d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.10747284459603657d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4205854326978514d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.374025623920916d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7662040896933204d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6632631342958567d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.47591158273788314d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8099814547250488d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7158105774146418d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.813708608900775d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7990648801057982d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.329286223605035d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5321874899858735d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.947937117640432d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6359479812179459d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.267012862956749d)));//InnerModel.Value

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
                var models =  ((IDoubleSingleTypedouble)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9873999463780074d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.40005401285299313d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6686100576833589d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7392361366093083d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6625871135435683d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.06354218638421472d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3188873185569653d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.14770998625782528d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.908308734862411d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6972496513672712d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3909202205485046d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9278079580475035d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.889966157079392d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.37968263809239433d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6635200408577636d)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5549943819394361d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5049089390684821d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8406702219370469d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8367010403259668d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6972780119690164d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.02154161374883634d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6205145231895781d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.19336247998719125d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8495128591120378d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6405931350929781d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3085578388507625d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.37908984045002436d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8767207779034873d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7843191984118333d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8428991858335863d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.12657015658650161d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8775139016923541d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9814076585901886d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9585026011177054d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2788036729528548d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.2648547177182038d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9977417853189705d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2032764632465096d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.9487653950369814d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8066286546468199d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4425763940189793d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4597185397773069d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7141394516068837d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6371517912287459d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.18038665386685104d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5798942831789303d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11020349401519969d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.27814592375789227d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8948685903155079d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17644498411902898d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4350771697775061d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.25470252581285857d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4100061236927609d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5529162681734514d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.860812512930953d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.10747284459603657d)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4205854326978514d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.374025623920916d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7662040896933204d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6632631342958567d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.47591158273788314d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8099814547250488d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7158105774146418d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.813708608900775d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7990648801057982d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.329286223605035d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5321874899858735d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.947937117640432d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6359479812179459d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.267012862956749d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

