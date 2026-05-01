

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
    internal partial interface IInt32SingleTypeint
    {
    }
    
    internal partial class Int32SingleTypeint : IInt32SingleTypeint
    {


#region TestData

        private readonly Int32int0M[] _testData = new Int32int0M[]
        {
            new Int32int0M
{
    Id = 8,
    Value = 2096076165,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 10,
    Value = 554306297,
    ModelInner = new Int32int0MI
{
    Id = 4,
    Value = 2002676437,
    NullableValue = 902703779,
},
    NullableValue = 330732017,
},
            new Int32int0M
{
    Id = 16,
    Value = 43469743,
    ModelInner = null,
    NullableValue = 101659193,
},
            new Int32int0M
{
    Id = 17,
    Value = 567781658,
    ModelInner = new Int32int0MI
{
    Id = 11,
    Value = 830320008,
    NullableValue = null,
},
    NullableValue = 1253105184,
},
            new Int32int0M
{
    Id = 22,
    Value = 1489840607,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 31,
    Value = 745760487,
    ModelInner = new Int32int0MI
{
    Id = 12,
    Value = 622838957,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 40,
    Value = 2015042005,
    ModelInner = null,
    NullableValue = 599246783,
},
            new Int32int0M
{
    Id = 44,
    Value = 1671489361,
    ModelInner = new Int32int0MI
{
    Id = 20,
    Value = 77456141,
    NullableValue = 980554341,
},
    NullableValue = 746367707,
},
            new Int32int0M
{
    Id = 46,
    Value = 1748069256,
    ModelInner = null,
    NullableValue = 1006555298,
},
            new Int32int0M
{
    Id = 47,
    Value = 118970597,
    ModelInner = new Int32int0MI
{
    Id = 22,
    Value = 686290316,
    NullableValue = 291693922,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 50,
    Value = 1404307842,
    ModelInner = null,
    NullableValue = 599208536,
},
            new Int32int0M
{
    Id = 55,
    Value = 174708741,
    ModelInner = new Int32int0MI
{
    Id = 31,
    Value = 765346543,
    NullableValue = 577465601,
},
    NullableValue = 2128999526,
},
            new Int32int0M
{
    Id = 56,
    Value = 881177466,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 59,
    Value = 884542535,
    ModelInner = new Int32int0MI
{
    Id = 36,
    Value = 1385687472,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 67,
    Value = 543553452,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 69,
    Value = 948525901,
    ModelInner = new Int32int0MI
{
    Id = 45,
    Value = 1921382405,
    NullableValue = 1342175004,
},
    NullableValue = 626861381,
},
            new Int32int0M
{
    Id = 71,
    Value = 1718997904,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 78,
    Value = 47677056,
    ModelInner = new Int32int0MI
{
    Id = 47,
    Value = 1702912709,
    NullableValue = 1209545904,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 82,
    Value = 1379732429,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 91,
    Value = 29699639,
    ModelInner = new Int32int0MI
{
    Id = 50,
    Value = 920231198,
    NullableValue = 1203335855,
},
    NullableValue = 94695710,
},
            new Int32int0M
{
    Id = 100,
    Value = 542441453,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 105,
    Value = 1624169718,
    ModelInner = new Int32int0MI
{
    Id = 54,
    Value = 1448300762,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 112,
    Value = 1980043474,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 116,
    Value = 481315304,
    ModelInner = new Int32int0MI
{
    Id = 62,
    Value = 451063487,
    NullableValue = null,
},
    NullableValue = 1435304909,
},
            new Int32int0M
{
    Id = 117,
    Value = 1010296916,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 120,
    Value = 278702207,
    ModelInner = new Int32int0MI
{
    Id = 71,
    Value = 1491209110,
    NullableValue = null,
},
    NullableValue = 842847951,
},
            new Int32int0M
{
    Id = 125,
    Value = 1651995616,
    ModelInner = null,
    NullableValue = 816135222,
},
            new Int32int0M
{
    Id = 134,
    Value = 923268750,
    ModelInner = new Int32int0MI
{
    Id = 79,
    Value = 782500605,
    NullableValue = 973711871,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 142,
    Value = 1683876422,
    ModelInner = null,
    NullableValue = 1964974495,
},
            new Int32int0M
{
    Id = 143,
    Value = 1569780771,
    ModelInner = new Int32int0MI
{
    Id = 80,
    Value = 182017903,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 148,
    Value = 131705064,
    ModelInner = null,
    NullableValue = 1390071325,
},
            new Int32int0M
{
    Id = 156,
    Value = 188476448,
    ModelInner = new Int32int0MI
{
    Id = 83,
    Value = 1451837619,
    NullableValue = 307696445,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 165,
    Value = 1028766586,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 171,
    Value = 258582400,
    ModelInner = new Int32int0MI
{
    Id = 86,
    Value = 50851037,
    NullableValue = 1186200694,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 178,
    Value = 456317854,
    ModelInner = null,
    NullableValue = 1929756207,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int0mi(
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
            asPartInterface: typeof(IInt32SingleTypeint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(3))]
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

                changedRows =  ((IInt32SingleTypeint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt32SingleTypeint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int0mi(
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
            asPartInterface: typeof(IInt32SingleTypeint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(11), 
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

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int0m(
	id,
    value,
    nullablevalue,
    int32int0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32int0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(3),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32int0mi_id", 
                methodParametrName: "int32int0mi_id", 
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

                changedRows =  ((IInt32SingleTypeint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IInt32SingleTypeint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int0m(
	id,
    value,
    nullablevalue,
    int32int0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32int0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(11),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32int0mi_id", 
                methodParametrName: "int32int0mi_id", 
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

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32int0M), typeof(FlatInt32int0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                await((IInt32SingleTypeint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                ((IInt32SingleTypeint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IInt32SingleTypeint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt32SingleTypeint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
LEFT JOIN gedaqtests.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
                var models = await((IInt32SingleTypeint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt32SingleTypeint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32int0M), typeof(FlatInt32int0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                await((IInt32SingleTypeint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                ((IInt32SingleTypeint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
LEFT JOIN gedaqtests.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
                var models = await((IInt32SingleTypeint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32SingleTypeint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32int0M), typeof(FlatInt32int0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                await((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt32int0M.AssertModel(models[0],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt32int0M.AssertModel(models[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt32int0M.AssertModel(models[0],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32int0M.AssertModel(models[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM gedaqtests.int32int0m m
LEFT JOIN gedaqtests.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
                var models = await((IInt32SingleTypeint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int32int0M.AssertModel(models[0],_testData[15], false);
                        Int32int0M.AssertModel(models[1],_testData[16], false);
                        Int32int0M.AssertModel(models[2],_testData[17], false);
                        Int32int0M.AssertModel(models[3],_testData[18], false);
                        Int32int0M.AssertModel(models[4],_testData[19], false);
                        Int32int0M.AssertModel(models[5],_testData[20], false);
                        Int32int0M.AssertModel(models[6],_testData[21], false);
                        Int32int0M.AssertModel(models[7],_testData[22], false);
                        Int32int0M.AssertModel(models[8],_testData[23], false);
                        Int32int0M.AssertModel(models[9],_testData[24], false);
                        Int32int0M.AssertModel(models[10],_testData[25], false);
                        Int32int0M.AssertModel(models[11],_testData[26], false);
                        Int32int0M.AssertModel(models[12],_testData[27], false);
                        Int32int0M.AssertModel(models[13],_testData[28], false);
                        Int32int0M.AssertModel(models[14],_testData[29], false);
                        Int32int0M.AssertModel(models[15],_testData[30], false);
                        Int32int0M.AssertModel(models[16],_testData[31], false);
                        Int32int0M.AssertModel(models[17],_testData[32], false);
                        Int32int0M.AssertModel(models[18],_testData[33], false);
                        Int32int0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int32int0M.AssertModel(models[0],_testData[4], false);
                        Int32int0M.AssertModel(models[1],_testData[5], false);
                        Int32int0M.AssertModel(models[2],_testData[6], false);
                        Int32int0M.AssertModel(models[3],_testData[7], false);
                        Int32int0M.AssertModel(models[4],_testData[8], false);
                        Int32int0M.AssertModel(models[5],_testData[9], false);
                        Int32int0M.AssertModel(models[6],_testData[10], false);
                        Int32int0M.AssertModel(models[7],_testData[11], false);
                        Int32int0M.AssertModel(models[8],_testData[12], false);
                        Int32int0M.AssertModel(models[9],_testData[13], false);
                        Int32int0M.AssertModel(models[10],_testData[14], false);
                        Int32int0M.AssertModel(models[11],_testData[15], false);
                        Int32int0M.AssertModel(models[12],_testData[16], false);
                        Int32int0M.AssertModel(models[13],_testData[17], false);
                        Int32int0M.AssertModel(models[14],_testData[18], false);
                        Int32int0M.AssertModel(models[15],_testData[19], false);
                        Int32int0M.AssertModel(models[16],_testData[20], false);
                        Int32int0M.AssertModel(models[17],_testData[21], false);
                        Int32int0M.AssertModel(models[18],_testData[22], false);
                        Int32int0M.AssertModel(models[19],_testData[23], false);
                        Int32int0M.AssertModel(models[20],_testData[24], false);
                        Int32int0M.AssertModel(models[21],_testData[25], false);
                        Int32int0M.AssertModel(models[22],_testData[26], false);
                        Int32int0M.AssertModel(models[23],_testData[27], false);
                        Int32int0M.AssertModel(models[24],_testData[28], false);
                        Int32int0M.AssertModel(models[25],_testData[29], false);
                        Int32int0M.AssertModel(models[26],_testData[30], false);
                        Int32int0M.AssertModel(models[27],_testData[31], false);
                        Int32int0M.AssertModel(models[28],_testData[32], false);
                        Int32int0M.AssertModel(models[29],_testData[33], false);
                        Int32int0M.AssertModel(models[30],_testData[34], false);
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
                var models = ((IInt32SingleTypeint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int32int0M.AssertModel(models[0],_testData[20], false);
                        Int32int0M.AssertModel(models[1],_testData[21], false);
                        Int32int0M.AssertModel(models[2],_testData[22], false);
                        Int32int0M.AssertModel(models[3],_testData[23], false);
                        Int32int0M.AssertModel(models[4],_testData[24], false);
                        Int32int0M.AssertModel(models[5],_testData[25], false);
                        Int32int0M.AssertModel(models[6],_testData[26], false);
                        Int32int0M.AssertModel(models[7],_testData[27], false);
                        Int32int0M.AssertModel(models[8],_testData[28], false);
                        Int32int0M.AssertModel(models[9],_testData[29], false);
                        Int32int0M.AssertModel(models[10],_testData[30], false);
                        Int32int0M.AssertModel(models[11],_testData[31], false);
                        Int32int0M.AssertModel(models[12],_testData[32], false);
                        Int32int0M.AssertModel(models[13],_testData[33], false);
                        Int32int0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int32int0M.AssertModel(models[0],_testData[18], false);
                        Int32int0M.AssertModel(models[1],_testData[19], false);
                        Int32int0M.AssertModel(models[2],_testData[20], false);
                        Int32int0M.AssertModel(models[3],_testData[21], false);
                        Int32int0M.AssertModel(models[4],_testData[22], false);
                        Int32int0M.AssertModel(models[5],_testData[23], false);
                        Int32int0M.AssertModel(models[6],_testData[24], false);
                        Int32int0M.AssertModel(models[7],_testData[25], false);
                        Int32int0M.AssertModel(models[8],_testData[26], false);
                        Int32int0M.AssertModel(models[9],_testData[27], false);
                        Int32int0M.AssertModel(models[10],_testData[28], false);
                        Int32int0M.AssertModel(models[11],_testData[29], false);
                        Int32int0M.AssertModel(models[12],_testData[30], false);
                        Int32int0M.AssertModel(models[13],_testData[31], false);
                        Int32int0M.AssertModel(models[14],_testData[32], false);
                        Int32int0M.AssertModel(models[15],_testData[33], false);
                        Int32int0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32int0M), typeof(FlatInt32int0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                await((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 50, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 125, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 143, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 46, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 55, query1, 10, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt32int0M.AssertModel(models[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt32int0M.AssertModel(models[0],_testData[2], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[3], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[4], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[5], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[6], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[7], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[8], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[25],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[26],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[27],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[28],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[29],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[30],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[31],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[32],_testData[34], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 46, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 17, query1, 10, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt32int0M.AssertModel(models[0],_testData[4], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[5], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[6], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[7], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[8], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[25],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[26],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[27],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[28],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[29],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt32int0M.AssertModel(models[0],_testData[2], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[3], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[4], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[5], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[6], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[7], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[8], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[25],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[26],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[27],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[28],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[29],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[30],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[31],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[32],_testData[34], false);
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
FROM gedaqtests.int32int0m m
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
FROM gedaqtests.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatch(connection, 165, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM gedaqtests.int32int0m m
LEFT JOIN gedaqtests.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32int0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
                var models = await((IInt32SingleTypeint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatchAsync(connection, 82, 44))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int32int0M.AssertModel(models[0],_testData[19], false);
                        Int32int0M.AssertModel(models[1],_testData[20], false);
                        Int32int0M.AssertModel(models[2],_testData[21], false);
                        Int32int0M.AssertModel(models[3],_testData[22], false);
                        Int32int0M.AssertModel(models[4],_testData[23], false);
                        Int32int0M.AssertModel(models[5],_testData[24], false);
                        Int32int0M.AssertModel(models[6],_testData[25], false);
                        Int32int0M.AssertModel(models[7],_testData[26], false);
                        Int32int0M.AssertModel(models[8],_testData[27], false);
                        Int32int0M.AssertModel(models[9],_testData[28], false);
                        Int32int0M.AssertModel(models[10],_testData[29], false);
                        Int32int0M.AssertModel(models[11],_testData[30], false);
                        Int32int0M.AssertModel(models[12],_testData[31], false);
                        Int32int0M.AssertModel(models[13],_testData[32], false);
                        Int32int0M.AssertModel(models[14],_testData[33], false);
                        Int32int0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int32int0M.AssertModel(models[0],_testData[8], false);
                        Int32int0M.AssertModel(models[1],_testData[9], false);
                        Int32int0M.AssertModel(models[2],_testData[10], false);
                        Int32int0M.AssertModel(models[3],_testData[11], false);
                        Int32int0M.AssertModel(models[4],_testData[12], false);
                        Int32int0M.AssertModel(models[5],_testData[13], false);
                        Int32int0M.AssertModel(models[6],_testData[14], false);
                        Int32int0M.AssertModel(models[7],_testData[15], false);
                        Int32int0M.AssertModel(models[8],_testData[16], false);
                        Int32int0M.AssertModel(models[9],_testData[17], false);
                        Int32int0M.AssertModel(models[10],_testData[18], false);
                        Int32int0M.AssertModel(models[11],_testData[19], false);
                        Int32int0M.AssertModel(models[12],_testData[20], false);
                        Int32int0M.AssertModel(models[13],_testData[21], false);
                        Int32int0M.AssertModel(models[14],_testData[22], false);
                        Int32int0M.AssertModel(models[15],_testData[23], false);
                        Int32int0M.AssertModel(models[16],_testData[24], false);
                        Int32int0M.AssertModel(models[17],_testData[25], false);
                        Int32int0M.AssertModel(models[18],_testData[26], false);
                        Int32int0M.AssertModel(models[19],_testData[27], false);
                        Int32int0M.AssertModel(models[20],_testData[28], false);
                        Int32int0M.AssertModel(models[21],_testData[29], false);
                        Int32int0M.AssertModel(models[22],_testData[30], false);
                        Int32int0M.AssertModel(models[23],_testData[31], false);
                        Int32int0M.AssertModel(models[24],_testData[32], false);
                        Int32int0M.AssertModel(models[25],_testData[33], false);
                        Int32int0M.AssertModel(models[26],_testData[34], false);
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
                var models = ((IInt32SingleTypeint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatch(connection, 142, 117))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int32int0M.AssertModel(models[0],_testData[29], false);
                        Int32int0M.AssertModel(models[1],_testData[30], false);
                        Int32int0M.AssertModel(models[2],_testData[31], false);
                        Int32int0M.AssertModel(models[3],_testData[32], false);
                        Int32int0M.AssertModel(models[4],_testData[33], false);
                        Int32int0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int32int0M.AssertModel(models[0],_testData[25], false);
                        Int32int0M.AssertModel(models[1],_testData[26], false);
                        Int32int0M.AssertModel(models[2],_testData[27], false);
                        Int32int0M.AssertModel(models[3],_testData[28], false);
                        Int32int0M.AssertModel(models[4],_testData[29], false);
                        Int32int0M.AssertModel(models[5],_testData[30], false);
                        Int32int0M.AssertModel(models[6],_testData[31], false);
                        Int32int0M.AssertModel(models[7],_testData[32], false);
                        Int32int0M.AssertModel(models[8],_testData[33], false);
                        Int32int0M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                Int32int0M.AssertModel(models[0],_testData[1], false);
                Int32int0M.AssertModel(models[1],_testData[2], false);
                Int32int0M.AssertModel(models[2],_testData[3], false);
                Int32int0M.AssertModel(models[3],_testData[4], false);
                Int32int0M.AssertModel(models[4],_testData[5], false);
                Int32int0M.AssertModel(models[5],_testData[6], false);
                Int32int0M.AssertModel(models[6],_testData[7], false);
                Int32int0M.AssertModel(models[7],_testData[8], false);
                Int32int0M.AssertModel(models[8],_testData[9], false);
                Int32int0M.AssertModel(models[9],_testData[10], false);
                Int32int0M.AssertModel(models[10],_testData[11], false);
                Int32int0M.AssertModel(models[11],_testData[12], false);
                Int32int0M.AssertModel(models[12],_testData[13], false);
                Int32int0M.AssertModel(models[13],_testData[14], false);
                Int32int0M.AssertModel(models[14],_testData[15], false);
                Int32int0M.AssertModel(models[15],_testData[16], false);
                Int32int0M.AssertModel(models[16],_testData[17], false);
                Int32int0M.AssertModel(models[17],_testData[18], false);
                Int32int0M.AssertModel(models[18],_testData[19], false);
                Int32int0M.AssertModel(models[19],_testData[20], false);
                Int32int0M.AssertModel(models[20],_testData[21], false);
                Int32int0M.AssertModel(models[21],_testData[22], false);
                Int32int0M.AssertModel(models[22],_testData[23], false);
                Int32int0M.AssertModel(models[23],_testData[24], false);
                Int32int0M.AssertModel(models[24],_testData[25], false);
                Int32int0M.AssertModel(models[25],_testData[26], false);
                Int32int0M.AssertModel(models[26],_testData[27], false);
                Int32int0M.AssertModel(models[27],_testData[28], false);
                Int32int0M.AssertModel(models[28],_testData[29], false);
                Int32int0M.AssertModel(models[29],_testData[30], false);
                Int32int0M.AssertModel(models[30],_testData[31], false);
                Int32int0M.AssertModel(models[31],_testData[32], false);
                Int32int0M.AssertModel(models[32],_testData[33], false);
                Int32int0M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 31);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                Int32int0M.AssertModel(models[0],_testData[6], false);
                Int32int0M.AssertModel(models[1],_testData[7], false);
                Int32int0M.AssertModel(models[2],_testData[8], false);
                Int32int0M.AssertModel(models[3],_testData[9], false);
                Int32int0M.AssertModel(models[4],_testData[10], false);
                Int32int0M.AssertModel(models[5],_testData[11], false);
                Int32int0M.AssertModel(models[6],_testData[12], false);
                Int32int0M.AssertModel(models[7],_testData[13], false);
                Int32int0M.AssertModel(models[8],_testData[14], false);
                Int32int0M.AssertModel(models[9],_testData[15], false);
                Int32int0M.AssertModel(models[10],_testData[16], false);
                Int32int0M.AssertModel(models[11],_testData[17], false);
                Int32int0M.AssertModel(models[12],_testData[18], false);
                Int32int0M.AssertModel(models[13],_testData[19], false);
                Int32int0M.AssertModel(models[14],_testData[20], false);
                Int32int0M.AssertModel(models[15],_testData[21], false);
                Int32int0M.AssertModel(models[16],_testData[22], false);
                Int32int0M.AssertModel(models[17],_testData[23], false);
                Int32int0M.AssertModel(models[18],_testData[24], false);
                Int32int0M.AssertModel(models[19],_testData[25], false);
                Int32int0M.AssertModel(models[20],_testData[26], false);
                Int32int0M.AssertModel(models[21],_testData[27], false);
                Int32int0M.AssertModel(models[22],_testData[28], false);
                Int32int0M.AssertModel(models[23],_testData[29], false);
                Int32int0M.AssertModel(models[24],_testData[30], false);
                Int32int0M.AssertModel(models[25],_testData[31], false);
                Int32int0M.AssertModel(models[26],_testData[32], false);
                Int32int0M.AssertModel(models[27],_testData[33], false);
                Int32int0M.AssertModel(models[28],_testData[34], false);
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
FROM gedaqtests.int32int0m m
LEFT JOIN gedaqtests.int32int0mi mi ON mi.id = m.int32int0mi_id
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
            asPartInterface: typeof(IInt32SingleTypeint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32SingleTypeint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2096076165)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((554306297)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2002676437)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((902703779)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((330732017)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((43469743)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((101659193)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((567781658)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((830320008)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1253105184)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1489840607)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((745760487)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((622838957)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2015042005)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((599246783)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1671489361)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((77456141)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((980554341)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((746367707)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1748069256)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1006555298)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((118970597)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((686290316)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((291693922)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1404307842)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((599208536)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((174708741)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((765346543)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((577465601)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2128999526)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((881177466)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((884542535)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1385687472)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((543553452)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((948525901)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1921382405)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1342175004)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((626861381)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1718997904)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((47677056)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1702912709)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1209545904)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1379732429)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((29699639)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((920231198)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1203335855)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((94695710)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((542441453)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1624169718)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1448300762)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1980043474)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((481315304)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((451063487)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1435304909)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1010296916)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((278702207)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1491209110)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((842847951)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1651995616)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((816135222)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((923268750)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((782500605)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((973711871)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1683876422)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1964974495)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1569780771)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((182017903)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((131705064)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1390071325)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((188476448)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1451837619)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((307696445)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1028766586)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((258582400)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((50851037)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1186200694)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((456317854)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1929756207)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32SingleTypeint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2096076165)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((554306297)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2002676437)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((902703779)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((330732017)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((43469743)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((101659193)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((567781658)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((830320008)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1253105184)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1489840607)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((745760487)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((622838957)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2015042005)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((599246783)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1671489361)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((77456141)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((980554341)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((746367707)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1748069256)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1006555298)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((118970597)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((686290316)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((291693922)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1404307842)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((599208536)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((174708741)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((765346543)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((577465601)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2128999526)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((881177466)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((884542535)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1385687472)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((543553452)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((948525901)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1921382405)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1342175004)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((626861381)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1718997904)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((47677056)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1702912709)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1209545904)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1379732429)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((29699639)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((920231198)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1203335855)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((94695710)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((542441453)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1624169718)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1448300762)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1980043474)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((481315304)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((451063487)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1435304909)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1010296916)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((278702207)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1491209110)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((842847951)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1651995616)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((816135222)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((923268750)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((782500605)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((973711871)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1683876422)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1964974495)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1569780771)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((182017903)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((131705064)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1390071325)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((188476448)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1451837619)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((307696445)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1028766586)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((258582400)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((50851037)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1186200694)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((456317854)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1929756207)));

            }
        }

#endregion

    }
}

