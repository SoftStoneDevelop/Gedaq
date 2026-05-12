

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

        private readonly DoubledoubleE0M[] _testData = new DoubledoubleE0M[]
        {
            new DoubledoubleE0M
{
    Id = 6,
    Value = 0.334425649763364d,
    ModelInner = null,
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 13,
    Value = 0.9804282317654548d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 1,
    Value = 0.06086954260242361d,
    NullableValue = 0.012890240033768818d,
},
    NullableValue = 0.27351333816539103d,
},
            new DoubledoubleE0M
{
    Id = 22,
    Value = 0.8214064721604519d,
    ModelInner = null,
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 24,
    Value = 0.5658048344273864d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 5,
    Value = 0.0002038006947610027d,
    NullableValue = 0.7282382954877736d,
},
    NullableValue = 0.9852675014020797d,
},
            new DoubledoubleE0M
{
    Id = 31,
    Value = 0.9815866054780232d,
    ModelInner = null,
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 35,
    Value = 0.1898267520068212d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 12,
    Value = 0.8623334925124082d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 37,
    Value = 0.7795141546906355d,
    ModelInner = null,
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 40,
    Value = 0.4889317918350078d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 17,
    Value = 0.8367795556657236d,
    NullableValue = 0.8236997943113764d,
},
    NullableValue = 0.7054096693769913d,
},
            new DoubledoubleE0M
{
    Id = 48,
    Value = 0.6359405810466138d,
    ModelInner = null,
    NullableValue = 0.6863933009533619d,
},
            new DoubledoubleE0M
{
    Id = 57,
    Value = 0.3732280056240087d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 19,
    Value = 0.06046915512969386d,
    NullableValue = null,
},
    NullableValue = 0.504529336941528d,
},
            new DoubledoubleE0M
{
    Id = 66,
    Value = 0.08568729439413714d,
    ModelInner = null,
    NullableValue = 0.9521363871636286d,
},
            new DoubledoubleE0M
{
    Id = 72,
    Value = 0.19804722673813202d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 25,
    Value = 0.6393006479229643d,
    NullableValue = 0.40014093281493d,
},
    NullableValue = 0.7332499444706005d,
},
            new DoubledoubleE0M
{
    Id = 79,
    Value = 0.30037020395915914d,
    ModelInner = null,
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 84,
    Value = 0.19098923421721525d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 28,
    Value = 0.779406638145424d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 92,
    Value = 0.721900438272817d,
    ModelInner = null,
    NullableValue = 0.03813648553489468d,
},
            new DoubledoubleE0M
{
    Id = 99,
    Value = 0.12103988363697571d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 37,
    Value = 0.4279576709455851d,
    NullableValue = 0.40493313694667266d,
},
    NullableValue = 0.043642123906702635d,
},
            new DoubledoubleE0M
{
    Id = 106,
    Value = 0.20833733810097554d,
    ModelInner = null,
    NullableValue = 0.5143893220581783d,
},
            new DoubledoubleE0M
{
    Id = 112,
    Value = 0.8033961562136585d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 45,
    Value = 0.4494996769675579d,
    NullableValue = 0.33861447430223846d,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 115,
    Value = 0.002152903769541914d,
    ModelInner = null,
    NullableValue = 0.27481730597312426d,
},
            new DoubledoubleE0M
{
    Id = 123,
    Value = 0.0893570576978755d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 53,
    Value = 0.6322494452200121d,
    NullableValue = null,
},
    NullableValue = 0.7381705754429779d,
},
            new DoubledoubleE0M
{
    Id = 130,
    Value = 0.10343360919714117d,
    ModelInner = null,
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 139,
    Value = 0.6997853642380689d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 55,
    Value = 0.31132107009501564d,
    NullableValue = 0.045101575705938424d,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 146,
    Value = 0.39600785908531866d,
    ModelInner = null,
    NullableValue = 0.1839691577353525d,
},
            new DoubledoubleE0M
{
    Id = 148,
    Value = 0.2435286736326061d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 62,
    Value = 0.33588705578703304d,
    NullableValue = 0.4251319474805453d,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 153,
    Value = 0.7385566632740929d,
    ModelInner = null,
    NullableValue = 0.7909909769137919d,
},
            new DoubledoubleE0M
{
    Id = 154,
    Value = 0.9964922654267615d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 64,
    Value = 0.11640951923468046d,
    NullableValue = 0.6684680936911006d,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 161,
    Value = 0.2605012618060807d,
    ModelInner = null,
    NullableValue = 0.8879036458020558d,
},
            new DoubledoubleE0M
{
    Id = 164,
    Value = 0.9410953921496488d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 67,
    Value = 0.9098794227060505d,
    NullableValue = 0.05577510017940435d,
},
    NullableValue = 0.36850066382476365d,
},
            new DoubledoubleE0M
{
    Id = 165,
    Value = 0.4390623576425291d,
    ModelInner = null,
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 167,
    Value = 0.871754849981506d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 69,
    Value = 0.05056418900410209d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 176,
    Value = 0.5375838113252301d,
    ModelInner = null,
    NullableValue = 0.9945820286308975d,
},
            new DoubledoubleE0M
{
    Id = 184,
    Value = 0.11559712779790443d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 74,
    Value = 0.9952487693940778d,
    NullableValue = 0.7780983621441163d,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 189,
    Value = 0.3750242677738166d,
    ModelInner = null,
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 195,
    Value = 0.7458676199915147d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 78,
    Value = 0.3416207752218091d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 197,
    Value = 0.27677288610629613d,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.doubledoublee0mi(
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
INSERT INTO gedaqtests.doubledoublee0mi(
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
INSERT INTO gedaqtests.doubledoublee0m(
	id,
    value,
    nullablevalue,
    doubledoublee0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doubledoublee0mi_id
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
                parametrName: "doubledoublee0mi_id", 
                methodParametrName: "doubledoublee0mi_id", 
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
INSERT INTO gedaqtests.doubledoublee0m(
	id,
    value,
    nullablevalue,
    doubledoublee0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doubledoublee0mi_id
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
                parametrName: "doubledoublee0mi_id", 
                methodParametrName: "doubledoublee0mi_id", 
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
            queryMapTypes: [typeof(FlatDoubledoubleE0M), typeof(FlatDoubledoubleE0M)],
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
FROM gedaqtests.doubledoublee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledoubleE0M>();
                var models2 = new List<FlatDoubledoubleE0M>();
                await((IDoubleSingleTypedouble)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledoubleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledoubleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledoublee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledoubleE0M>();
                var models2 = new List<FlatDoubledoubleE0M>();
                ((IDoubleSingleTypedouble)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledoubleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledoubleE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledoubleE0M)],
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
FROM gedaqtests.doubledoublee0m m
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
                    FlatDoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledoublee0m m
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
                    FlatDoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledoublee0m m
LEFT JOIN gedaqtests.doubledoublee0mi mi ON mi.id = m.doubledoublee0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DoubledoubleE0M)],
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
                    DoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
                    DoubledoubleE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledoubleE0M), typeof(FlatDoubledoubleE0M)],
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
FROM gedaqtests.doubledoublee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledoubleE0M>();
                var models2 = new List<FlatDoubledoubleE0M>();
                await((IDoubleSingleTypedouble)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledoubleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledoubleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledoublee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledoubleE0M>();
                var models2 = new List<FlatDoubledoubleE0M>();
                ((IDoubleSingleTypedouble)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledoubleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledoubleE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledoubleE0M)],
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
FROM gedaqtests.doubledoublee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypedouble)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledoublee0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledoublee0m m
LEFT JOIN gedaqtests.doubledoublee0mi mi ON mi.id = m.doubledoublee0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DoubledoubleE0M)],
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
                    DoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
                    DoubledoubleE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledoubleE0M), typeof(FlatDoubledoubleE0M)],
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledoubleE0M>();
                var models2 = new List<FlatDoubledoubleE0M>();
                await((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledoubleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledoubleE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 37;
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledoubleE0M>();
                var firstItems2 = new List<FlatDoubledoubleE0M>();
                var secondItems1 = new List<FlatDoubledoubleE0M>();
                var secondItems2 = new List<FlatDoubledoubleE0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledoubleE0M>();
                var firstItems2 = new List<FlatDoubledoubleE0M>();
                var secondItems1 = new List<FlatDoubledoubleE0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledoubleE0M>();
                var models2 = new List<FlatDoubledoubleE0M>();
                ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledoubleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledoubleE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledoubleE0M>();
                var firstItems2 = new List<FlatDoubledoubleE0M>();
                var secondItems1 = new List<FlatDoubledoubleE0M>();
                var secondItems2 = new List<FlatDoubledoubleE0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledoubleE0M>();
                var firstItems2 = new List<FlatDoubledoubleE0M>();
                var secondItems1 = new List<FlatDoubledoubleE0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledoubleE0M)],
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
FROM gedaqtests.doubledoublee0m m
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
                    FlatDoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[3], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[4], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[5], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[6], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(models[7],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(models[8],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(models[9],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(models[10],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(models[11],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(models[12],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(models[13],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(models[14],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(models[15],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(models[16],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(models[17],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(models[18],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(models[19],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(models[20],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(models[21],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(models[22],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(models[23],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(models[24],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(models[25],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[26],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[27],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[28],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[29],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[30],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledoubleE0M>();
                var secondItems1 = new List<FlatDoubledoubleE0M>();
                var secondItems2 = new List<FlatDoubledoubleE0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM gedaqtests.doubledoublee0m m
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
                    FlatDoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(models[7],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(models[8],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(models[9],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(models[10],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(models[11],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(models[12],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(models[13],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(models[14],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(models[15],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(models[16],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(models[17],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[18],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[19],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[20],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[21],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[22],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(models[7],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(models[8],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(models[9],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(models[10],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[11],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[12],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[13],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[14],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[15],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 115;
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledoubleE0M>();
                var secondItems1 = new List<FlatDoubledoubleE0M>();
                var secondItems2 = new List<FlatDoubledoubleE0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM gedaqtests.doubledoublee0m m
LEFT JOIN gedaqtests.doubledoublee0mi mi ON mi.id = m.doubledoublee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DoubledoubleE0M)],
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
                    DoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DoubledoubleE0M.AssertModel(models[0],_testData[27], false);
                        DoubledoubleE0M.AssertModel(models[1],_testData[28], false);
                        DoubledoubleE0M.AssertModel(models[2],_testData[29], false);
                        DoubledoubleE0M.AssertModel(models[3],_testData[30], false);
                        DoubledoubleE0M.AssertModel(models[4],_testData[31], false);
                        DoubledoubleE0M.AssertModel(models[5],_testData[32], false);
                        DoubledoubleE0M.AssertModel(models[6],_testData[33], false);
                        DoubledoubleE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        DoubledoubleE0M.AssertModel(models[0],_testData[25], false);
                        DoubledoubleE0M.AssertModel(models[1],_testData[26], false);
                        DoubledoubleE0M.AssertModel(models[2],_testData[27], false);
                        DoubledoubleE0M.AssertModel(models[3],_testData[28], false);
                        DoubledoubleE0M.AssertModel(models[4],_testData[29], false);
                        DoubledoubleE0M.AssertModel(models[5],_testData[30], false);
                        DoubledoubleE0M.AssertModel(models[6],_testData[31], false);
                        DoubledoubleE0M.AssertModel(models[7],_testData[32], false);
                        DoubledoubleE0M.AssertModel(models[8],_testData[33], false);
                        DoubledoubleE0M.AssertModel(models[9],_testData[34], false);
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
                    DoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 184;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DoubledoubleE0M.AssertModel(models[0],_testData[3], false);
                        DoubledoubleE0M.AssertModel(models[1],_testData[4], false);
                        DoubledoubleE0M.AssertModel(models[2],_testData[5], false);
                        DoubledoubleE0M.AssertModel(models[3],_testData[6], false);
                        DoubledoubleE0M.AssertModel(models[4],_testData[7], false);
                        DoubledoubleE0M.AssertModel(models[5],_testData[8], false);
                        DoubledoubleE0M.AssertModel(models[6],_testData[9], false);
                        DoubledoubleE0M.AssertModel(models[7],_testData[10], false);
                        DoubledoubleE0M.AssertModel(models[8],_testData[11], false);
                        DoubledoubleE0M.AssertModel(models[9],_testData[12], false);
                        DoubledoubleE0M.AssertModel(models[10],_testData[13], false);
                        DoubledoubleE0M.AssertModel(models[11],_testData[14], false);
                        DoubledoubleE0M.AssertModel(models[12],_testData[15], false);
                        DoubledoubleE0M.AssertModel(models[13],_testData[16], false);
                        DoubledoubleE0M.AssertModel(models[14],_testData[17], false);
                        DoubledoubleE0M.AssertModel(models[15],_testData[18], false);
                        DoubledoubleE0M.AssertModel(models[16],_testData[19], false);
                        DoubledoubleE0M.AssertModel(models[17],_testData[20], false);
                        DoubledoubleE0M.AssertModel(models[18],_testData[21], false);
                        DoubledoubleE0M.AssertModel(models[19],_testData[22], false);
                        DoubledoubleE0M.AssertModel(models[20],_testData[23], false);
                        DoubledoubleE0M.AssertModel(models[21],_testData[24], false);
                        DoubledoubleE0M.AssertModel(models[22],_testData[25], false);
                        DoubledoubleE0M.AssertModel(models[23],_testData[26], false);
                        DoubledoubleE0M.AssertModel(models[24],_testData[27], false);
                        DoubledoubleE0M.AssertModel(models[25],_testData[28], false);
                        DoubledoubleE0M.AssertModel(models[26],_testData[29], false);
                        DoubledoubleE0M.AssertModel(models[27],_testData[30], false);
                        DoubledoubleE0M.AssertModel(models[28],_testData[31], false);
                        DoubledoubleE0M.AssertModel(models[29],_testData[32], false);
                        DoubledoubleE0M.AssertModel(models[30],_testData[33], false);
                        DoubledoubleE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DoubledoubleE0M.AssertModel(models[0],_testData[32], false);
                        DoubledoubleE0M.AssertModel(models[1],_testData[33], false);
                        DoubledoubleE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledoubleE0M), typeof(FlatDoubledoubleE0M)],
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledoubleE0M>();
                var models2 = new List<FlatDoubledoubleE0M>();
                await((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledoubleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledoubleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledoubleE0M>();
                var firstItems2 = new List<FlatDoubledoubleE0M>();
                var secondItems1 = new List<FlatDoubledoubleE0M>();
                var secondItems2 = new List<FlatDoubledoubleE0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 148, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledoubleE0M>();
                var firstItems2 = new List<FlatDoubledoubleE0M>();
                var secondItems1 = new List<FlatDoubledoubleE0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 115, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledoubleE0M>();
                var models2 = new List<FlatDoubledoubleE0M>();
                ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledoubleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledoubleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledoubleE0M>();
                var firstItems2 = new List<FlatDoubledoubleE0M>();
                var secondItems1 = new List<FlatDoubledoubleE0M>();
                var secondItems2 = new List<FlatDoubledoubleE0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 123, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledoubleE0M>();
                var firstItems2 = new List<FlatDoubledoubleE0M>();
                var secondItems1 = new List<FlatDoubledoubleE0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatch(connection, 72, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledoubleE0M)],
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 57, query1, 164, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(models[7],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(models[8],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(models[9],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(models[10],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(models[11],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(models[12],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(models[13],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(models[14],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(models[15],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(models[16],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(models[17],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(models[18],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[19],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[20],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[21],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[22],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[23],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[34], false);
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledoubleE0M>();
                var secondItems1 = new List<FlatDoubledoubleE0M>();
                var secondItems2 = new List<FlatDoubledoubleE0M>();
                await ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 72, query1, 154, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatch(connection, 24, query1, 161, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[7],_testData[34], false);
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
FROM gedaqtests.doubledoublee0m m
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
FROM gedaqtests.doubledoublee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledoubleE0M>();
                var secondItems1 = new List<FlatDoubledoubleE0M>();
                var secondItems2 = new List<FlatDoubledoubleE0M>();
                 ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatch(connection, 37, query1, 154, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM gedaqtests.doubledoublee0m m
LEFT JOIN gedaqtests.doubledoublee0mi mi ON mi.id = m.doubledoublee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DoubledoubleE0M)],
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
                    DoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatchAsync(connection, 66, 161))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DoubledoubleE0M.AssertModel(models[0],_testData[11], false);
                        DoubledoubleE0M.AssertModel(models[1],_testData[12], false);
                        DoubledoubleE0M.AssertModel(models[2],_testData[13], false);
                        DoubledoubleE0M.AssertModel(models[3],_testData[14], false);
                        DoubledoubleE0M.AssertModel(models[4],_testData[15], false);
                        DoubledoubleE0M.AssertModel(models[5],_testData[16], false);
                        DoubledoubleE0M.AssertModel(models[6],_testData[17], false);
                        DoubledoubleE0M.AssertModel(models[7],_testData[18], false);
                        DoubledoubleE0M.AssertModel(models[8],_testData[19], false);
                        DoubledoubleE0M.AssertModel(models[9],_testData[20], false);
                        DoubledoubleE0M.AssertModel(models[10],_testData[21], false);
                        DoubledoubleE0M.AssertModel(models[11],_testData[22], false);
                        DoubledoubleE0M.AssertModel(models[12],_testData[23], false);
                        DoubledoubleE0M.AssertModel(models[13],_testData[24], false);
                        DoubledoubleE0M.AssertModel(models[14],_testData[25], false);
                        DoubledoubleE0M.AssertModel(models[15],_testData[26], false);
                        DoubledoubleE0M.AssertModel(models[16],_testData[27], false);
                        DoubledoubleE0M.AssertModel(models[17],_testData[28], false);
                        DoubledoubleE0M.AssertModel(models[18],_testData[29], false);
                        DoubledoubleE0M.AssertModel(models[19],_testData[30], false);
                        DoubledoubleE0M.AssertModel(models[20],_testData[31], false);
                        DoubledoubleE0M.AssertModel(models[21],_testData[32], false);
                        DoubledoubleE0M.AssertModel(models[22],_testData[33], false);
                        DoubledoubleE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DoubledoubleE0M.AssertModel(models[0],_testData[27], false);
                        DoubledoubleE0M.AssertModel(models[1],_testData[28], false);
                        DoubledoubleE0M.AssertModel(models[2],_testData[29], false);
                        DoubledoubleE0M.AssertModel(models[3],_testData[30], false);
                        DoubledoubleE0M.AssertModel(models[4],_testData[31], false);
                        DoubledoubleE0M.AssertModel(models[5],_testData[32], false);
                        DoubledoubleE0M.AssertModel(models[6],_testData[33], false);
                        DoubledoubleE0M.AssertModel(models[7],_testData[34], false);
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
                    DoubledoubleE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatch(connection, 164, 154))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DoubledoubleE0M.AssertModel(models[0],_testData[28], false);
                        DoubledoubleE0M.AssertModel(models[1],_testData[29], false);
                        DoubledoubleE0M.AssertModel(models[2],_testData[30], false);
                        DoubledoubleE0M.AssertModel(models[3],_testData[31], false);
                        DoubledoubleE0M.AssertModel(models[4],_testData[32], false);
                        DoubledoubleE0M.AssertModel(models[5],_testData[33], false);
                        DoubledoubleE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DoubledoubleE0M.AssertModel(models[0],_testData[26], false);
                        DoubledoubleE0M.AssertModel(models[1],_testData[27], false);
                        DoubledoubleE0M.AssertModel(models[2],_testData[28], false);
                        DoubledoubleE0M.AssertModel(models[3],_testData[29], false);
                        DoubledoubleE0M.AssertModel(models[4],_testData[30], false);
                        DoubledoubleE0M.AssertModel(models[5],_testData[31], false);
                        DoubledoubleE0M.AssertModel(models[6],_testData[32], false);
                        DoubledoubleE0M.AssertModel(models[7],_testData[33], false);
                        DoubledoubleE0M.AssertModel(models[8],_testData[34], false);
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
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 146);
                var models = await ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                DoubledoubleE0M.AssertModel(models[0],_testData[23], false);
                DoubledoubleE0M.AssertModel(models[1],_testData[24], false);
                DoubledoubleE0M.AssertModel(models[2],_testData[25], false);
                DoubledoubleE0M.AssertModel(models[3],_testData[26], false);
                DoubledoubleE0M.AssertModel(models[4],_testData[27], false);
                DoubledoubleE0M.AssertModel(models[5],_testData[28], false);
                DoubledoubleE0M.AssertModel(models[6],_testData[29], false);
                DoubledoubleE0M.AssertModel(models[7],_testData[30], false);
                DoubledoubleE0M.AssertModel(models[8],_testData[31], false);
                DoubledoubleE0M.AssertModel(models[9],_testData[32], false);
                DoubledoubleE0M.AssertModel(models[10],_testData[33], false);
                DoubledoubleE0M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypedouble)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models =  ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                DoubledoubleE0M.AssertModel(models[0],_testData[9], false);
                DoubledoubleE0M.AssertModel(models[1],_testData[10], false);
                DoubledoubleE0M.AssertModel(models[2],_testData[11], false);
                DoubledoubleE0M.AssertModel(models[3],_testData[12], false);
                DoubledoubleE0M.AssertModel(models[4],_testData[13], false);
                DoubledoubleE0M.AssertModel(models[5],_testData[14], false);
                DoubledoubleE0M.AssertModel(models[6],_testData[15], false);
                DoubledoubleE0M.AssertModel(models[7],_testData[16], false);
                DoubledoubleE0M.AssertModel(models[8],_testData[17], false);
                DoubledoubleE0M.AssertModel(models[9],_testData[18], false);
                DoubledoubleE0M.AssertModel(models[10],_testData[19], false);
                DoubledoubleE0M.AssertModel(models[11],_testData[20], false);
                DoubledoubleE0M.AssertModel(models[12],_testData[21], false);
                DoubledoubleE0M.AssertModel(models[13],_testData[22], false);
                DoubledoubleE0M.AssertModel(models[14],_testData[23], false);
                DoubledoubleE0M.AssertModel(models[15],_testData[24], false);
                DoubledoubleE0M.AssertModel(models[16],_testData[25], false);
                DoubledoubleE0M.AssertModel(models[17],_testData[26], false);
                DoubledoubleE0M.AssertModel(models[18],_testData[27], false);
                DoubledoubleE0M.AssertModel(models[19],_testData[28], false);
                DoubledoubleE0M.AssertModel(models[20],_testData[29], false);
                DoubledoubleE0M.AssertModel(models[21],_testData[30], false);
                DoubledoubleE0M.AssertModel(models[22],_testData[31], false);
                DoubledoubleE0M.AssertModel(models[23],_testData[32], false);
                DoubledoubleE0M.AssertModel(models[24],_testData[33], false);
                DoubledoubleE0M.AssertModel(models[25],_testData[34], false);
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
FROM gedaqtests.doubledoublee0m m
LEFT JOIN gedaqtests.doubledoublee0mi mi ON mi.id = m.doubledoublee0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.334425649763364d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9804282317654548d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06086954260242361d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.012890240033768818d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.27351333816539103d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8214064721604519d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5658048344273864d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.0002038006947610027d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7282382954877736d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9852675014020797d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9815866054780232d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1898267520068212d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8623334925124082d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7795141546906355d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4889317918350078d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8367795556657236d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8236997943113764d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7054096693769913d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6359405810466138d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6863933009533619d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3732280056240087d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06046915512969386d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.504529336941528d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08568729439413714d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9521363871636286d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19804722673813202d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6393006479229643d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.40014093281493d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7332499444706005d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.30037020395915914d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19098923421721525d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.779406638145424d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.721900438272817d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.03813648553489468d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.12103988363697571d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4279576709455851d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.40493313694667266d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.043642123906702635d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20833733810097554d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5143893220581783d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8033961562136585d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4494996769675579d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.33861447430223846d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.002152903769541914d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.27481730597312426d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.0893570576978755d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6322494452200121d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7381705754429779d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10343360919714117d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6997853642380689d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.31132107009501564d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.045101575705938424d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.39600785908531866d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.1839691577353525d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2435286736326061d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.33588705578703304d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4251319474805453d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7385566632740929d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7909909769137919d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9964922654267615d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11640951923468046d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6684680936911006d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2605012618060807d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8879036458020558d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9410953921496488d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9098794227060505d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.05577510017940435d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.36850066382476365d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4390623576425291d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.871754849981506d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05056418900410209d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5375838113252301d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9945820286308975d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.11559712779790443d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9952487693940778d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7780983621441163d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3750242677738166d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7458676199915147d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3416207752218091d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((197)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.27677288610629613d)));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.334425649763364d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9804282317654548d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06086954260242361d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.012890240033768818d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.27351333816539103d)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8214064721604519d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5658048344273864d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.0002038006947610027d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7282382954877736d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9852675014020797d)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9815866054780232d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.1898267520068212d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8623334925124082d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7795141546906355d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4889317918350078d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8367795556657236d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8236997943113764d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7054096693769913d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6359405810466138d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6863933009533619d)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3732280056240087d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06046915512969386d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.504529336941528d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.08568729439413714d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9521363871636286d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19804722673813202d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6393006479229643d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.40014093281493d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7332499444706005d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.30037020395915914d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.19098923421721525d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.779406638145424d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.721900438272817d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.03813648553489468d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.12103988363697571d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4279576709455851d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.40493313694667266d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.043642123906702635d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.20833733810097554d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5143893220581783d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8033961562136585d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4494996769675579d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.33861447430223846d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.002152903769541914d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.27481730597312426d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.0893570576978755d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6322494452200121d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7381705754429779d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10343360919714117d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6997853642380689d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.31132107009501564d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.045101575705938424d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.39600785908531866d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.1839691577353525d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2435286736326061d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.33588705578703304d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4251319474805453d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7385566632740929d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7909909769137919d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9964922654267615d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11640951923468046d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6684680936911006d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2605012618060807d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8879036458020558d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9410953921496488d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9098794227060505d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.05577510017940435d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.36850066382476365d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4390623576425291d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.871754849981506d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.05056418900410209d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5375838113252301d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9945820286308975d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.11559712779790443d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9952487693940778d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7780983621441163d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3750242677738166d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7458676199915147d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3416207752218091d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((197)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.27677288610629613d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

