

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
    Id = 1,
    Value = 0.4063605933913258d,
    ModelInner = null,
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 8,
    Value = 0.3008089040348031d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 7,
    Value = 0.7898132476347137d,
    NullableValue = 0.4628334682491657d,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 14,
    Value = 0.17681133215338263d,
    ModelInner = null,
    NullableValue = 0.8755194800934044d,
},
            new DoubledoubleE0M
{
    Id = 18,
    Value = 0.3943075327314006d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 14,
    Value = 0.23450907375399987d,
    NullableValue = 0.7615079249722995d,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 27,
    Value = 0.8679019785450351d,
    ModelInner = null,
    NullableValue = 0.23402453421385816d,
},
            new DoubledoubleE0M
{
    Id = 28,
    Value = 0.8158824432885574d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 17,
    Value = 0.18270099358686231d,
    NullableValue = 0.6682903150255153d,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 35,
    Value = 0.9024982676486458d,
    ModelInner = null,
    NullableValue = 0.06227506308393704d,
},
            new DoubledoubleE0M
{
    Id = 41,
    Value = 0.2251108361375952d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 24,
    Value = 0.08018652663671477d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 42,
    Value = 0.7792881846863143d,
    ModelInner = null,
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 47,
    Value = 0.3421539787946172d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 30,
    Value = 0.45511084200159213d,
    NullableValue = 0.6295781806223025d,
},
    NullableValue = 0.24021151169220833d,
},
            new DoubledoubleE0M
{
    Id = 56,
    Value = 0.8247359101508246d,
    ModelInner = null,
    NullableValue = 0.16662331361646388d,
},
            new DoubledoubleE0M
{
    Id = 60,
    Value = 0.5196815370225111d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 34,
    Value = 0.3400258529973137d,
    NullableValue = null,
},
    NullableValue = 0.955280496269088d,
},
            new DoubledoubleE0M
{
    Id = 69,
    Value = 0.2758518213751331d,
    ModelInner = null,
    NullableValue = 0.8082718652067198d,
},
            new DoubledoubleE0M
{
    Id = 72,
    Value = 0.5794232385782385d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 43,
    Value = 0.5978800255896823d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 75,
    Value = 0.531570295966801d,
    ModelInner = null,
    NullableValue = 0.5838054158195162d,
},
            new DoubledoubleE0M
{
    Id = 83,
    Value = 0.7558679562811929d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 52,
    Value = 0.3875114637118524d,
    NullableValue = 0.4523171250464818d,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 86,
    Value = 0.5908796287893336d,
    ModelInner = null,
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 94,
    Value = 0.0814877991918379d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 60,
    Value = 0.42780866962828434d,
    NullableValue = 0.56333377863271d,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 101,
    Value = 0.32443671492233683d,
    ModelInner = null,
    NullableValue = 0.36576760294483d,
},
            new DoubledoubleE0M
{
    Id = 102,
    Value = 0.2894103981097784d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 62,
    Value = 0.731026828223181d,
    NullableValue = null,
},
    NullableValue = 0.7773944942721869d,
},
            new DoubledoubleE0M
{
    Id = 110,
    Value = 0.48932614433285626d,
    ModelInner = null,
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 114,
    Value = 0.7741665376652828d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 65,
    Value = 0.3017274870738943d,
    NullableValue = 0.08787150798275323d,
},
    NullableValue = 0.45106903958409594d,
},
            new DoubledoubleE0M
{
    Id = 122,
    Value = 0.7884986768853202d,
    ModelInner = null,
    NullableValue = 0.26536359164113776d,
},
            new DoubledoubleE0M
{
    Id = 126,
    Value = 0.8965367124919007d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 68,
    Value = 0.3635278427305485d,
    NullableValue = 0.1129737302870607d,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 135,
    Value = 0.10466639130123945d,
    ModelInner = null,
    NullableValue = 0.3686232878103053d,
},
            new DoubledoubleE0M
{
    Id = 142,
    Value = 0.17084535808242662d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 77,
    Value = 0.7156754618779858d,
    NullableValue = 0.54607926635742d,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 149,
    Value = 0.4148296871890341d,
    ModelInner = null,
    NullableValue = 0.9439654366836863d,
},
            new DoubledoubleE0M
{
    Id = 157,
    Value = 0.39045536550543414d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 80,
    Value = 0.4611056189032009d,
    NullableValue = null,
},
    NullableValue = 0.9941457775028509d,
},
            new DoubledoubleE0M
{
    Id = 161,
    Value = 0.3879188945666161d,
    ModelInner = null,
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 168,
    Value = 0.2211361735324281d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 82,
    Value = 0.2176697973757259d,
    NullableValue = null,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 177,
    Value = 0.5424908707422962d,
    ModelInner = null,
    NullableValue = 0.19302444904298666d,
},
            new DoubledoubleE0M
{
    Id = 181,
    Value = 0.831412999172753d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 91,
    Value = 0.030743050199617095d,
    NullableValue = 0.7990246207357327d,
},
    NullableValue = null,
},
            new DoubledoubleE0M
{
    Id = 186,
    Value = 0.17527770571059642d,
    ModelInner = null,
    NullableValue = 0.985982385980015d,
},
            new DoubledoubleE0M
{
    Id = 189,
    Value = 0.7002819399671883d,
    ModelInner = new DoubledoubleE0MI
{
    Id = 96,
    Value = 0.918636269476718d,
    NullableValue = null,
},
    NullableValue = 0.5004584577278518d,
},
            new DoubledoubleE0M
{
    Id = 195,
    Value = 0.40549479102318087d,
    ModelInner = null,
    NullableValue = 0.09603609956746473d,
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 186;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 177;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[34], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
                parametr1.Value = 101;
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 18;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[7],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[8],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[19],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[17],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[18],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[19],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[20],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[21],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DoubledoubleE0M.AssertModel(models[0],_testData[2], false);
                        DoubledoubleE0M.AssertModel(models[1],_testData[3], false);
                        DoubledoubleE0M.AssertModel(models[2],_testData[4], false);
                        DoubledoubleE0M.AssertModel(models[3],_testData[5], false);
                        DoubledoubleE0M.AssertModel(models[4],_testData[6], false);
                        DoubledoubleE0M.AssertModel(models[5],_testData[7], false);
                        DoubledoubleE0M.AssertModel(models[6],_testData[8], false);
                        DoubledoubleE0M.AssertModel(models[7],_testData[9], false);
                        DoubledoubleE0M.AssertModel(models[8],_testData[10], false);
                        DoubledoubleE0M.AssertModel(models[9],_testData[11], false);
                        DoubledoubleE0M.AssertModel(models[10],_testData[12], false);
                        DoubledoubleE0M.AssertModel(models[11],_testData[13], false);
                        DoubledoubleE0M.AssertModel(models[12],_testData[14], false);
                        DoubledoubleE0M.AssertModel(models[13],_testData[15], false);
                        DoubledoubleE0M.AssertModel(models[14],_testData[16], false);
                        DoubledoubleE0M.AssertModel(models[15],_testData[17], false);
                        DoubledoubleE0M.AssertModel(models[16],_testData[18], false);
                        DoubledoubleE0M.AssertModel(models[17],_testData[19], false);
                        DoubledoubleE0M.AssertModel(models[18],_testData[20], false);
                        DoubledoubleE0M.AssertModel(models[19],_testData[21], false);
                        DoubledoubleE0M.AssertModel(models[20],_testData[22], false);
                        DoubledoubleE0M.AssertModel(models[21],_testData[23], false);
                        DoubledoubleE0M.AssertModel(models[22],_testData[24], false);
                        DoubledoubleE0M.AssertModel(models[23],_testData[25], false);
                        DoubledoubleE0M.AssertModel(models[24],_testData[26], false);
                        DoubledoubleE0M.AssertModel(models[25],_testData[27], false);
                        DoubledoubleE0M.AssertModel(models[26],_testData[28], false);
                        DoubledoubleE0M.AssertModel(models[27],_testData[29], false);
                        DoubledoubleE0M.AssertModel(models[28],_testData[30], false);
                        DoubledoubleE0M.AssertModel(models[29],_testData[31], false);
                        DoubledoubleE0M.AssertModel(models[30],_testData[32], false);
                        DoubledoubleE0M.AssertModel(models[31],_testData[33], false);
                        DoubledoubleE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DoubledoubleE0M.AssertModel(models[0],_testData[15], false);
                        DoubledoubleE0M.AssertModel(models[1],_testData[16], false);
                        DoubledoubleE0M.AssertModel(models[2],_testData[17], false);
                        DoubledoubleE0M.AssertModel(models[3],_testData[18], false);
                        DoubledoubleE0M.AssertModel(models[4],_testData[19], false);
                        DoubledoubleE0M.AssertModel(models[5],_testData[20], false);
                        DoubledoubleE0M.AssertModel(models[6],_testData[21], false);
                        DoubledoubleE0M.AssertModel(models[7],_testData[22], false);
                        DoubledoubleE0M.AssertModel(models[8],_testData[23], false);
                        DoubledoubleE0M.AssertModel(models[9],_testData[24], false);
                        DoubledoubleE0M.AssertModel(models[10],_testData[25], false);
                        DoubledoubleE0M.AssertModel(models[11],_testData[26], false);
                        DoubledoubleE0M.AssertModel(models[12],_testData[27], false);
                        DoubledoubleE0M.AssertModel(models[13],_testData[28], false);
                        DoubledoubleE0M.AssertModel(models[14],_testData[29], false);
                        DoubledoubleE0M.AssertModel(models[15],_testData[30], false);
                        DoubledoubleE0M.AssertModel(models[16],_testData[31], false);
                        DoubledoubleE0M.AssertModel(models[17],_testData[32], false);
                        DoubledoubleE0M.AssertModel(models[18],_testData[33], false);
                        DoubledoubleE0M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DoubledoubleE0M.AssertModel(models[0],_testData[17], false);
                        DoubledoubleE0M.AssertModel(models[1],_testData[18], false);
                        DoubledoubleE0M.AssertModel(models[2],_testData[19], false);
                        DoubledoubleE0M.AssertModel(models[3],_testData[20], false);
                        DoubledoubleE0M.AssertModel(models[4],_testData[21], false);
                        DoubledoubleE0M.AssertModel(models[5],_testData[22], false);
                        DoubledoubleE0M.AssertModel(models[6],_testData[23], false);
                        DoubledoubleE0M.AssertModel(models[7],_testData[24], false);
                        DoubledoubleE0M.AssertModel(models[8],_testData[25], false);
                        DoubledoubleE0M.AssertModel(models[9],_testData[26], false);
                        DoubledoubleE0M.AssertModel(models[10],_testData[27], false);
                        DoubledoubleE0M.AssertModel(models[11],_testData[28], false);
                        DoubledoubleE0M.AssertModel(models[12],_testData[29], false);
                        DoubledoubleE0M.AssertModel(models[13],_testData[30], false);
                        DoubledoubleE0M.AssertModel(models[14],_testData[31], false);
                        DoubledoubleE0M.AssertModel(models[15],_testData[32], false);
                        DoubledoubleE0M.AssertModel(models[16],_testData[33], false);
                        DoubledoubleE0M.AssertModel(models[17],_testData[34], false);
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
                await ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 149, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[13],_testData[34], false);
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
                await ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 149, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[7],_testData[34], false);
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
                 ((IDoubleSingleTypedouble)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 27, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[29],_testData[34], false);
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
                 ((IDoubleSingleTypedouble)this).DbConnectionMMDynQuerySelectModelBatch(connection, 168, query1, 157, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[6],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 122, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[7],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[8],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[9],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[10],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(models[7],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(models[8],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(models[9],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(models[10],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(models[11],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(models[12],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(models[13],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[14],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[15],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[16],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[17],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[18],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[19],_testData[34], false);
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
                await ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 28, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[28],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTDynQuerySelectModelBatch(connection, 72, query1, 181, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledoubleE0M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledoubleE0M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledoubleE0M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledoubleE0M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledoubleE0M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledoubleE0M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledoubleE0M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledoubleE0M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledoubleE0M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledoubleE0M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledoubleE0M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledoubleE0M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledoubleE0M.AssertModel(models[0],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(models[1],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(models[2],_testData[34], false);
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
                 ((IDoubleSingleTypedouble)this).DbConnectionDynQuerySelectModelBatch(connection, 157, query1, 161, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledoubleE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledoubleE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDoubledoubleE0M.AssertModel(secondItems2[5],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatchAsync(connection, 135, 14))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble)this).DbConnectionSTSelectModelBatch(connection, 1, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DoubledoubleE0M.AssertModel(models[0],_testData[1], false);
                        DoubledoubleE0M.AssertModel(models[1],_testData[2], false);
                        DoubledoubleE0M.AssertModel(models[2],_testData[3], false);
                        DoubledoubleE0M.AssertModel(models[3],_testData[4], false);
                        DoubledoubleE0M.AssertModel(models[4],_testData[5], false);
                        DoubledoubleE0M.AssertModel(models[5],_testData[6], false);
                        DoubledoubleE0M.AssertModel(models[6],_testData[7], false);
                        DoubledoubleE0M.AssertModel(models[7],_testData[8], false);
                        DoubledoubleE0M.AssertModel(models[8],_testData[9], false);
                        DoubledoubleE0M.AssertModel(models[9],_testData[10], false);
                        DoubledoubleE0M.AssertModel(models[10],_testData[11], false);
                        DoubledoubleE0M.AssertModel(models[11],_testData[12], false);
                        DoubledoubleE0M.AssertModel(models[12],_testData[13], false);
                        DoubledoubleE0M.AssertModel(models[13],_testData[14], false);
                        DoubledoubleE0M.AssertModel(models[14],_testData[15], false);
                        DoubledoubleE0M.AssertModel(models[15],_testData[16], false);
                        DoubledoubleE0M.AssertModel(models[16],_testData[17], false);
                        DoubledoubleE0M.AssertModel(models[17],_testData[18], false);
                        DoubledoubleE0M.AssertModel(models[18],_testData[19], false);
                        DoubledoubleE0M.AssertModel(models[19],_testData[20], false);
                        DoubledoubleE0M.AssertModel(models[20],_testData[21], false);
                        DoubledoubleE0M.AssertModel(models[21],_testData[22], false);
                        DoubledoubleE0M.AssertModel(models[22],_testData[23], false);
                        DoubledoubleE0M.AssertModel(models[23],_testData[24], false);
                        DoubledoubleE0M.AssertModel(models[24],_testData[25], false);
                        DoubledoubleE0M.AssertModel(models[25],_testData[26], false);
                        DoubledoubleE0M.AssertModel(models[26],_testData[27], false);
                        DoubledoubleE0M.AssertModel(models[27],_testData[28], false);
                        DoubledoubleE0M.AssertModel(models[28],_testData[29], false);
                        DoubledoubleE0M.AssertModel(models[29],_testData[30], false);
                        DoubledoubleE0M.AssertModel(models[30],_testData[31], false);
                        DoubledoubleE0M.AssertModel(models[31],_testData[32], false);
                        DoubledoubleE0M.AssertModel(models[32],_testData[33], false);
                        DoubledoubleE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DoubledoubleE0M.AssertModel(models[0],_testData[6], false);
                        DoubledoubleE0M.AssertModel(models[1],_testData[7], false);
                        DoubledoubleE0M.AssertModel(models[2],_testData[8], false);
                        DoubledoubleE0M.AssertModel(models[3],_testData[9], false);
                        DoubledoubleE0M.AssertModel(models[4],_testData[10], false);
                        DoubledoubleE0M.AssertModel(models[5],_testData[11], false);
                        DoubledoubleE0M.AssertModel(models[6],_testData[12], false);
                        DoubledoubleE0M.AssertModel(models[7],_testData[13], false);
                        DoubledoubleE0M.AssertModel(models[8],_testData[14], false);
                        DoubledoubleE0M.AssertModel(models[9],_testData[15], false);
                        DoubledoubleE0M.AssertModel(models[10],_testData[16], false);
                        DoubledoubleE0M.AssertModel(models[11],_testData[17], false);
                        DoubledoubleE0M.AssertModel(models[12],_testData[18], false);
                        DoubledoubleE0M.AssertModel(models[13],_testData[19], false);
                        DoubledoubleE0M.AssertModel(models[14],_testData[20], false);
                        DoubledoubleE0M.AssertModel(models[15],_testData[21], false);
                        DoubledoubleE0M.AssertModel(models[16],_testData[22], false);
                        DoubledoubleE0M.AssertModel(models[17],_testData[23], false);
                        DoubledoubleE0M.AssertModel(models[18],_testData[24], false);
                        DoubledoubleE0M.AssertModel(models[19],_testData[25], false);
                        DoubledoubleE0M.AssertModel(models[20],_testData[26], false);
                        DoubledoubleE0M.AssertModel(models[21],_testData[27], false);
                        DoubledoubleE0M.AssertModel(models[22],_testData[28], false);
                        DoubledoubleE0M.AssertModel(models[23],_testData[29], false);
                        DoubledoubleE0M.AssertModel(models[24],_testData[30], false);
                        DoubledoubleE0M.AssertModel(models[25],_testData[31], false);
                        DoubledoubleE0M.AssertModel(models[26],_testData[32], false);
                        DoubledoubleE0M.AssertModel(models[27],_testData[33], false);
                        DoubledoubleE0M.AssertModel(models[28],_testData[34], false);
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
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 126);
                var models = await ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                DoubledoubleE0M.AssertModel(models[0],_testData[24], false);
                DoubledoubleE0M.AssertModel(models[1],_testData[25], false);
                DoubledoubleE0M.AssertModel(models[2],_testData[26], false);
                DoubledoubleE0M.AssertModel(models[3],_testData[27], false);
                DoubledoubleE0M.AssertModel(models[4],_testData[28], false);
                DoubledoubleE0M.AssertModel(models[5],_testData[29], false);
                DoubledoubleE0M.AssertModel(models[6],_testData[30], false);
                DoubledoubleE0M.AssertModel(models[7],_testData[31], false);
                DoubledoubleE0M.AssertModel(models[8],_testData[32], false);
                DoubledoubleE0M.AssertModel(models[9],_testData[33], false);
                DoubledoubleE0M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypedouble)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypedouble)this).SetDbConnectionSelectModelParametrs(cmd, 86);
                var models =  ((IDoubleSingleTypedouble)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                DoubledoubleE0M.AssertModel(models[0],_testData[17], false);
                DoubledoubleE0M.AssertModel(models[1],_testData[18], false);
                DoubledoubleE0M.AssertModel(models[2],_testData[19], false);
                DoubledoubleE0M.AssertModel(models[3],_testData[20], false);
                DoubledoubleE0M.AssertModel(models[4],_testData[21], false);
                DoubledoubleE0M.AssertModel(models[5],_testData[22], false);
                DoubledoubleE0M.AssertModel(models[6],_testData[23], false);
                DoubledoubleE0M.AssertModel(models[7],_testData[24], false);
                DoubledoubleE0M.AssertModel(models[8],_testData[25], false);
                DoubledoubleE0M.AssertModel(models[9],_testData[26], false);
                DoubledoubleE0M.AssertModel(models[10],_testData[27], false);
                DoubledoubleE0M.AssertModel(models[11],_testData[28], false);
                DoubledoubleE0M.AssertModel(models[12],_testData[29], false);
                DoubledoubleE0M.AssertModel(models[13],_testData[30], false);
                DoubledoubleE0M.AssertModel(models[14],_testData[31], false);
                DoubledoubleE0M.AssertModel(models[15],_testData[32], false);
                DoubledoubleE0M.AssertModel(models[16],_testData[33], false);
                DoubledoubleE0M.AssertModel(models[17],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4063605933913258d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3008089040348031d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7898132476347137d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4628334682491657d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17681133215338263d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8755194800934044d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3943075327314006d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.23450907375399987d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7615079249722995d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8679019785450351d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.23402453421385816d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8158824432885574d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.18270099358686231d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6682903150255153d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9024982676486458d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.06227506308393704d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2251108361375952d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08018652663671477d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7792881846863143d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3421539787946172d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.45511084200159213d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6295781806223025d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.24021151169220833d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8247359101508246d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.16662331361646388d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5196815370225111d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3400258529973137d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.955280496269088d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2758518213751331d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8082718652067198d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5794232385782385d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5978800255896823d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.531570295966801d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5838054158195162d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7558679562811929d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3875114637118524d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4523171250464818d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5908796287893336d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.0814877991918379d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.42780866962828434d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.56333377863271d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.32443671492233683d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.36576760294483d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2894103981097784d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.731026828223181d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7773944942721869d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.48932614433285626d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7741665376652828d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3017274870738943d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.08787150798275323d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.45106903958409594d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7884986768853202d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.26536359164113776d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8965367124919007d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3635278427305485d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.1129737302870607d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10466639130123945d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3686232878103053d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17084535808242662d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7156754618779858d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.54607926635742d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4148296871890341d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9439654366836863d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.39045536550543414d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4611056189032009d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9941457775028509d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3879188945666161d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2211361735324281d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2176697973757259d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5424908707422962d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.19302444904298666d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.831412999172753d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.030743050199617095d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7990246207357327d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17527770571059642d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.985982385980015d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7002819399671883d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.918636269476718d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5004584577278518d)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40549479102318087d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.09603609956746473d)));

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
                Assert.That((System.Double)model[1], Is.EqualTo((0.4063605933913258d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3008089040348031d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7898132476347137d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4628334682491657d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17681133215338263d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8755194800934044d)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3943075327314006d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.23450907375399987d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7615079249722995d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8679019785450351d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.23402453421385816d)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8158824432885574d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.18270099358686231d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6682903150255153d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9024982676486458d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.06227506308393704d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2251108361375952d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.08018652663671477d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7792881846863143d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3421539787946172d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.45511084200159213d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.6295781806223025d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.24021151169220833d)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8247359101508246d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.16662331361646388d)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5196815370225111d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3400258529973137d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.955280496269088d)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2758518213751331d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8082718652067198d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5794232385782385d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5978800255896823d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.531570295966801d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5838054158195162d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7558679562811929d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3875114637118524d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.4523171250464818d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5908796287893336d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.0814877991918379d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.42780866962828434d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.56333377863271d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.32443671492233683d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.36576760294483d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2894103981097784d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.731026828223181d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7773944942721869d)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.48932614433285626d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7741665376652828d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3017274870738943d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.08787150798275323d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.45106903958409594d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7884986768853202d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.26536359164113776d)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8965367124919007d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.3635278427305485d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.1129737302870607d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.10466639130123945d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.3686232878103053d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17084535808242662d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7156754618779858d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.54607926635742d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4148296871890341d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9439654366836863d)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.39045536550543414d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4611056189032009d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.9941457775028509d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.3879188945666161d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.2211361735324281d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2176697973757259d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5424908707422962d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.19302444904298666d)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.831412999172753d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.030743050199617095d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7990246207357327d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.17527770571059642d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.985982385980015d)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7002819399671883d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((96)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.918636269476718d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.5004584577278518d)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.40549479102318087d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.09603609956746473d)));

            }
        }

#endregion

    }
}

