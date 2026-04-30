

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
    Id = 7,
    Value = 344843653,
    ModelInner = null,
    NullableValue = 34598645,
},
            new Int32int0M
{
    Id = 16,
    Value = 1642989623,
    ModelInner = new Int32int0MI
{
    Id = 8,
    Value = 1128630772,
    NullableValue = null,
},
    NullableValue = 803023708,
},
            new Int32int0M
{
    Id = 19,
    Value = 1545300295,
    ModelInner = null,
    NullableValue = 1832080972,
},
            new Int32int0M
{
    Id = 25,
    Value = 1057761996,
    ModelInner = new Int32int0MI
{
    Id = 14,
    Value = 1977921436,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 29,
    Value = 2046551392,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 37,
    Value = 192265369,
    ModelInner = new Int32int0MI
{
    Id = 20,
    Value = 346783575,
    NullableValue = 1083205771,
},
    NullableValue = 200222852,
},
            new Int32int0M
{
    Id = 43,
    Value = 1749939263,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 46,
    Value = 875739383,
    ModelInner = new Int32int0MI
{
    Id = 21,
    Value = 1863965720,
    NullableValue = 1756432429,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 55,
    Value = 562312077,
    ModelInner = null,
    NullableValue = 1337176338,
},
            new Int32int0M
{
    Id = 61,
    Value = 782513600,
    ModelInner = new Int32int0MI
{
    Id = 24,
    Value = 49223878,
    NullableValue = 1413398733,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 69,
    Value = 1290161742,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 77,
    Value = 1465631407,
    ModelInner = new Int32int0MI
{
    Id = 25,
    Value = 1895519012,
    NullableValue = null,
},
    NullableValue = 1207012902,
},
            new Int32int0M
{
    Id = 81,
    Value = 372195973,
    ModelInner = null,
    NullableValue = 256499091,
},
            new Int32int0M
{
    Id = 83,
    Value = 1132298338,
    ModelInner = new Int32int0MI
{
    Id = 33,
    Value = 212787498,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 87,
    Value = 1591236653,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 94,
    Value = 1154796949,
    ModelInner = new Int32int0MI
{
    Id = 42,
    Value = 1706873783,
    NullableValue = 688780637,
},
    NullableValue = 1062130592,
},
            new Int32int0M
{
    Id = 97,
    Value = 1064417979,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 99,
    Value = 561446720,
    ModelInner = new Int32int0MI
{
    Id = 51,
    Value = 418389497,
    NullableValue = 782231969,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 101,
    Value = 1217885730,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 104,
    Value = 1571604524,
    ModelInner = new Int32int0MI
{
    Id = 56,
    Value = 199380950,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 109,
    Value = 417511462,
    ModelInner = null,
    NullableValue = 1151085968,
},
            new Int32int0M
{
    Id = 111,
    Value = 398324800,
    ModelInner = new Int32int0MI
{
    Id = 63,
    Value = 844033799,
    NullableValue = 444735132,
},
    NullableValue = 1583302966,
},
            new Int32int0M
{
    Id = 116,
    Value = 219696049,
    ModelInner = null,
    NullableValue = 426125029,
},
            new Int32int0M
{
    Id = 122,
    Value = 362789127,
    ModelInner = new Int32int0MI
{
    Id = 72,
    Value = 1541070842,
    NullableValue = 1980962675,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 131,
    Value = 1426812983,
    ModelInner = null,
    NullableValue = 566289997,
},
            new Int32int0M
{
    Id = 138,
    Value = 141631773,
    ModelInner = new Int32int0MI
{
    Id = 81,
    Value = 872655804,
    NullableValue = 2021884012,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 141,
    Value = 1176090330,
    ModelInner = null,
    NullableValue = 884224552,
},
            new Int32int0M
{
    Id = 148,
    Value = 1839826287,
    ModelInner = new Int32int0MI
{
    Id = 90,
    Value = 569343239,
    NullableValue = 779774955,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 154,
    Value = 1121670436,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 157,
    Value = 1128731485,
    ModelInner = new Int32int0MI
{
    Id = 97,
    Value = 2143568786,
    NullableValue = 125464150,
},
    NullableValue = 1445439145,
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
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
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32int0M.AssertModel(models[0],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt32int0M.AssertModel(models[0],_testData[3], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[4], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[5], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[6], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[7], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[8], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[25],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int32int0M.AssertModel(models[0],_testData[5], false);
                        Int32int0M.AssertModel(models[1],_testData[6], false);
                        Int32int0M.AssertModel(models[2],_testData[7], false);
                        Int32int0M.AssertModel(models[3],_testData[8], false);
                        Int32int0M.AssertModel(models[4],_testData[9], false);
                        Int32int0M.AssertModel(models[5],_testData[10], false);
                        Int32int0M.AssertModel(models[6],_testData[11], false);
                        Int32int0M.AssertModel(models[7],_testData[12], false);
                        Int32int0M.AssertModel(models[8],_testData[13], false);
                        Int32int0M.AssertModel(models[9],_testData[14], false);
                        Int32int0M.AssertModel(models[10],_testData[15], false);
                        Int32int0M.AssertModel(models[11],_testData[16], false);
                        Int32int0M.AssertModel(models[12],_testData[17], false);
                        Int32int0M.AssertModel(models[13],_testData[18], false);
                        Int32int0M.AssertModel(models[14],_testData[19], false);
                        Int32int0M.AssertModel(models[15],_testData[20], false);
                        Int32int0M.AssertModel(models[16],_testData[21], false);
                        Int32int0M.AssertModel(models[17],_testData[22], false);
                        Int32int0M.AssertModel(models[18],_testData[23], false);
                        Int32int0M.AssertModel(models[19],_testData[24], false);
                        Int32int0M.AssertModel(models[20],_testData[25], false);
                        Int32int0M.AssertModel(models[21],_testData[26], false);
                        Int32int0M.AssertModel(models[22],_testData[27], false);
                        Int32int0M.AssertModel(models[23],_testData[28], false);
                        Int32int0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int32int0M.AssertModel(models[0],_testData[27], false);
                        Int32int0M.AssertModel(models[1],_testData[28], false);
                        Int32int0M.AssertModel(models[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int32int0M.AssertModel(models[0],_testData[16], false);
                        Int32int0M.AssertModel(models[1],_testData[17], false);
                        Int32int0M.AssertModel(models[2],_testData[18], false);
                        Int32int0M.AssertModel(models[3],_testData[19], false);
                        Int32int0M.AssertModel(models[4],_testData[20], false);
                        Int32int0M.AssertModel(models[5],_testData[21], false);
                        Int32int0M.AssertModel(models[6],_testData[22], false);
                        Int32int0M.AssertModel(models[7],_testData[23], false);
                        Int32int0M.AssertModel(models[8],_testData[24], false);
                        Int32int0M.AssertModel(models[9],_testData[25], false);
                        Int32int0M.AssertModel(models[10],_testData[26], false);
                        Int32int0M.AssertModel(models[11],_testData[27], false);
                        Int32int0M.AssertModel(models[12],_testData[28], false);
                        Int32int0M.AssertModel(models[13],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 131, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[29], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 61, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 122, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[29], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 29, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 29, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt32int0M.AssertModel(models[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt32int0M.AssertModel(models[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[29], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 109, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 141, query1, 43, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt32int0M.AssertModel(models[0],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt32int0M.AssertModel(models[0],_testData[7], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[8], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[29], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatch(connection, 61, query1, 55, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatchAsync(connection, 122, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int32int0M.AssertModel(models[0],_testData[24], false);
                        Int32int0M.AssertModel(models[1],_testData[25], false);
                        Int32int0M.AssertModel(models[2],_testData[26], false);
                        Int32int0M.AssertModel(models[3],_testData[27], false);
                        Int32int0M.AssertModel(models[4],_testData[28], false);
                        Int32int0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int32int0M.AssertModel(models[0],_testData[27], false);
                        Int32int0M.AssertModel(models[1],_testData[28], false);
                        Int32int0M.AssertModel(models[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatch(connection, 29, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int32int0M.AssertModel(models[0],_testData[5], false);
                        Int32int0M.AssertModel(models[1],_testData[6], false);
                        Int32int0M.AssertModel(models[2],_testData[7], false);
                        Int32int0M.AssertModel(models[3],_testData[8], false);
                        Int32int0M.AssertModel(models[4],_testData[9], false);
                        Int32int0M.AssertModel(models[5],_testData[10], false);
                        Int32int0M.AssertModel(models[6],_testData[11], false);
                        Int32int0M.AssertModel(models[7],_testData[12], false);
                        Int32int0M.AssertModel(models[8],_testData[13], false);
                        Int32int0M.AssertModel(models[9],_testData[14], false);
                        Int32int0M.AssertModel(models[10],_testData[15], false);
                        Int32int0M.AssertModel(models[11],_testData[16], false);
                        Int32int0M.AssertModel(models[12],_testData[17], false);
                        Int32int0M.AssertModel(models[13],_testData[18], false);
                        Int32int0M.AssertModel(models[14],_testData[19], false);
                        Int32int0M.AssertModel(models[15],_testData[20], false);
                        Int32int0M.AssertModel(models[16],_testData[21], false);
                        Int32int0M.AssertModel(models[17],_testData[22], false);
                        Int32int0M.AssertModel(models[18],_testData[23], false);
                        Int32int0M.AssertModel(models[19],_testData[24], false);
                        Int32int0M.AssertModel(models[20],_testData[25], false);
                        Int32int0M.AssertModel(models[21],_testData[26], false);
                        Int32int0M.AssertModel(models[22],_testData[27], false);
                        Int32int0M.AssertModel(models[23],_testData[28], false);
                        Int32int0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int32int0M.AssertModel(models[0],_testData[16], false);
                        Int32int0M.AssertModel(models[1],_testData[17], false);
                        Int32int0M.AssertModel(models[2],_testData[18], false);
                        Int32int0M.AssertModel(models[3],_testData[19], false);
                        Int32int0M.AssertModel(models[4],_testData[20], false);
                        Int32int0M.AssertModel(models[5],_testData[21], false);
                        Int32int0M.AssertModel(models[6],_testData[22], false);
                        Int32int0M.AssertModel(models[7],_testData[23], false);
                        Int32int0M.AssertModel(models[8],_testData[24], false);
                        Int32int0M.AssertModel(models[9],_testData[25], false);
                        Int32int0M.AssertModel(models[10],_testData[26], false);
                        Int32int0M.AssertModel(models[11],_testData[27], false);
                        Int32int0M.AssertModel(models[12],_testData[28], false);
                        Int32int0M.AssertModel(models[13],_testData[29], false);
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
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 29);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
Int32int0M.AssertModel(models[0],_testData[5], false);Int32int0M.AssertModel(models[1],_testData[6], false);Int32int0M.AssertModel(models[2],_testData[7], false);Int32int0M.AssertModel(models[3],_testData[8], false);Int32int0M.AssertModel(models[4],_testData[9], false);Int32int0M.AssertModel(models[5],_testData[10], false);Int32int0M.AssertModel(models[6],_testData[11], false);Int32int0M.AssertModel(models[7],_testData[12], false);Int32int0M.AssertModel(models[8],_testData[13], false);Int32int0M.AssertModel(models[9],_testData[14], false);Int32int0M.AssertModel(models[10],_testData[15], false);Int32int0M.AssertModel(models[11],_testData[16], false);Int32int0M.AssertModel(models[12],_testData[17], false);Int32int0M.AssertModel(models[13],_testData[18], false);Int32int0M.AssertModel(models[14],_testData[19], false);Int32int0M.AssertModel(models[15],_testData[20], false);Int32int0M.AssertModel(models[16],_testData[21], false);Int32int0M.AssertModel(models[17],_testData[22], false);Int32int0M.AssertModel(models[18],_testData[23], false);Int32int0M.AssertModel(models[19],_testData[24], false);Int32int0M.AssertModel(models[20],_testData[25], false);Int32int0M.AssertModel(models[21],_testData[26], false);Int32int0M.AssertModel(models[22],_testData[27], false);Int32int0M.AssertModel(models[23],_testData[28], false);Int32int0M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 29);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
Int32int0M.AssertModel(models[0],_testData[5], false);Int32int0M.AssertModel(models[1],_testData[6], false);Int32int0M.AssertModel(models[2],_testData[7], false);Int32int0M.AssertModel(models[3],_testData[8], false);Int32int0M.AssertModel(models[4],_testData[9], false);Int32int0M.AssertModel(models[5],_testData[10], false);Int32int0M.AssertModel(models[6],_testData[11], false);Int32int0M.AssertModel(models[7],_testData[12], false);Int32int0M.AssertModel(models[8],_testData[13], false);Int32int0M.AssertModel(models[9],_testData[14], false);Int32int0M.AssertModel(models[10],_testData[15], false);Int32int0M.AssertModel(models[11],_testData[16], false);Int32int0M.AssertModel(models[12],_testData[17], false);Int32int0M.AssertModel(models[13],_testData[18], false);Int32int0M.AssertModel(models[14],_testData[19], false);Int32int0M.AssertModel(models[15],_testData[20], false);Int32int0M.AssertModel(models[16],_testData[21], false);Int32int0M.AssertModel(models[17],_testData[22], false);Int32int0M.AssertModel(models[18],_testData[23], false);Int32int0M.AssertModel(models[19],_testData[24], false);Int32int0M.AssertModel(models[20],_testData[25], false);Int32int0M.AssertModel(models[21],_testData[26], false);Int32int0M.AssertModel(models[22],_testData[27], false);Int32int0M.AssertModel(models[23],_testData[28], false);Int32int0M.AssertModel(models[24],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((344843653)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((34598645)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1642989623)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1128630772)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((803023708)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1545300295)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1832080972)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1057761996)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1977921436)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2046551392)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((192265369)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((346783575)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1083205771)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((200222852)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1749939263)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((875739383)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1863965720)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1756432429)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((562312077)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1337176338)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((782513600)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((49223878)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1413398733)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1290161742)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1465631407)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1895519012)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1207012902)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((372195973)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((256499091)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1132298338)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((212787498)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1591236653)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1154796949)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1706873783)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((688780637)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1062130592)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1064417979)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((561446720)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((418389497)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((782231969)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1217885730)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1571604524)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((199380950)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((417511462)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1151085968)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((398324800)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((844033799)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((444735132)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1583302966)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((219696049)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((426125029)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((362789127)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1541070842)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1980962675)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1426812983)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((566289997)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((141631773)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((872655804)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2021884012)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1176090330)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((884224552)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1839826287)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((569343239)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((779774955)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1121670436)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1128731485)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2143568786)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((125464150)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1445439145)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32SingleTypeint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((344843653)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((34598645)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1642989623)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1128630772)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((803023708)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1545300295)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1832080972)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1057761996)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1977921436)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2046551392)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((192265369)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((346783575)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1083205771)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((200222852)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1749939263)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((875739383)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1863965720)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1756432429)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((562312077)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1337176338)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((782513600)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((49223878)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1413398733)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1290161742)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1465631407)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1895519012)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1207012902)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((372195973)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((256499091)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1132298338)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((212787498)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1591236653)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1154796949)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1706873783)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((688780637)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1062130592)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1064417979)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((561446720)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((418389497)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((782231969)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1217885730)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1571604524)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((199380950)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((417511462)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1151085968)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((398324800)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((844033799)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((444735132)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1583302966)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((219696049)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((426125029)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((362789127)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1541070842)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1980962675)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1426812983)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((566289997)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((141631773)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((872655804)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2021884012)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1176090330)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((884224552)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1839826287)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((569343239)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((779774955)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1121670436)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1128731485)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((97)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2143568786)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((125464150)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1445439145)));

            }
        }

#endregion

    }
}

