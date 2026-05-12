

using Microsoft.Data.SqlClient;
using Gedaq.Common.Enums;
using Gedaq.SqlClient.Attributes;
using System;


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

        private readonly Int32intE0M[] _testData = new Int32intE0M[]
        {
            new Int32intE0M
{
    Id = 9,
    Value = 1083835304,
    ModelInner = null,
    NullableValue = 1505920864,
},
            new Int32intE0M
{
    Id = 18,
    Value = 1627342726,
    ModelInner = new Int32intE0MI
{
    Id = 9,
    Value = 146268894,
    NullableValue = 234467337,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 22,
    Value = 1601333160,
    ModelInner = null,
    NullableValue = 722171777,
},
            new Int32intE0M
{
    Id = 31,
    Value = 856245861,
    ModelInner = new Int32intE0MI
{
    Id = 17,
    Value = 143562741,
    NullableValue = null,
},
    NullableValue = 1482749341,
},
            new Int32intE0M
{
    Id = 38,
    Value = 664101243,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 47,
    Value = 865105372,
    ModelInner = new Int32intE0MI
{
    Id = 25,
    Value = 1587045791,
    NullableValue = null,
},
    NullableValue = 858200908,
},
            new Int32intE0M
{
    Id = 55,
    Value = 1252716598,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 57,
    Value = 1923177307,
    ModelInner = new Int32intE0MI
{
    Id = 28,
    Value = 280555827,
    NullableValue = 889583465,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 58,
    Value = 1571959604,
    ModelInner = null,
    NullableValue = 1603726101,
},
            new Int32intE0M
{
    Id = 65,
    Value = 956054356,
    ModelInner = new Int32intE0MI
{
    Id = 32,
    Value = 1981962582,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 74,
    Value = 565254386,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 76,
    Value = 1999173762,
    ModelInner = new Int32intE0MI
{
    Id = 41,
    Value = 484558864,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 85,
    Value = 849884320,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 88,
    Value = 1566069862,
    ModelInner = new Int32intE0MI
{
    Id = 47,
    Value = 704636241,
    NullableValue = 582705557,
},
    NullableValue = 1187625257,
},
            new Int32intE0M
{
    Id = 92,
    Value = 2003224059,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 98,
    Value = 1109399650,
    ModelInner = new Int32intE0MI
{
    Id = 51,
    Value = 948550307,
    NullableValue = 1428079623,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 101,
    Value = 1782735580,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 109,
    Value = 251773046,
    ModelInner = new Int32intE0MI
{
    Id = 54,
    Value = 1823385,
    NullableValue = 1066564731,
},
    NullableValue = 2114155909,
},
            new Int32intE0M
{
    Id = 117,
    Value = 219591127,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 124,
    Value = 1883467087,
    ModelInner = new Int32intE0MI
{
    Id = 55,
    Value = 1437274433,
    NullableValue = 183244218,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 125,
    Value = 1672263349,
    ModelInner = null,
    NullableValue = 1834323800,
},
            new Int32intE0M
{
    Id = 134,
    Value = 1453404247,
    ModelInner = new Int32intE0MI
{
    Id = 61,
    Value = 1624953616,
    NullableValue = null,
},
    NullableValue = 2111134466,
},
            new Int32intE0M
{
    Id = 141,
    Value = 539846370,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 146,
    Value = 155133257,
    ModelInner = new Int32intE0MI
{
    Id = 64,
    Value = 799186262,
    NullableValue = 607128244,
},
    NullableValue = 1901788108,
},
            new Int32intE0M
{
    Id = 153,
    Value = 1652593733,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 156,
    Value = 1532376504,
    ModelInner = new Int32intE0MI
{
    Id = 65,
    Value = 373782622,
    NullableValue = null,
},
    NullableValue = 758859538,
},
            new Int32intE0M
{
    Id = 162,
    Value = 1965007784,
    ModelInner = null,
    NullableValue = 1465350593,
},
            new Int32intE0M
{
    Id = 169,
    Value = 1180561055,
    ModelInner = new Int32intE0MI
{
    Id = 73,
    Value = 1983747067,
    NullableValue = 691519492,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 174,
    Value = 1854758254,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 177,
    Value = 1905834342,
    ModelInner = new Int32intE0MI
{
    Id = 74,
    Value = 988412034,
    NullableValue = null,
},
    NullableValue = 834839823,
},
            new Int32intE0M
{
    Id = 180,
    Value = 1315564193,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 181,
    Value = 4957151,
    ModelInner = new Int32intE0MI
{
    Id = 77,
    Value = 1800050064,
    NullableValue = 306043728,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 183,
    Value = 1761479593,
    ModelInner = null,
    NullableValue = 522068153,
},
            new Int32intE0M
{
    Id = 187,
    Value = 1061640307,
    ModelInner = new Int32intE0MI
{
    Id = 85,
    Value = 1532738748,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 191,
    Value = 1030550190,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int32inte0mi(
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(8))
            ]
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
INSERT INTO dbo.int32inte0mi(
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
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)11, 
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

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int32inte0m(
	id,
    value,
    nullablevalue,
    int32inte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32inte0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(8),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32inte0mi_id", 
                methodParametrName: "int32inte0mi_id", 
                dbType: (System.Data.SqlDbType)(8),
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
INSERT INTO dbo.int32inte0m(
	id,
    value,
    nullablevalue,
    int32inte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32inte0mi_id
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
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)11,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32inte0mi_id", 
                methodParametrName: "int32inte0mi_id", 
                dbType: (System.Data.DbType)11,
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

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32intE0M), typeof(FlatInt32intE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                await((IInt32SingleTypeint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                ((IInt32SingleTypeint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32intE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IInt32SingleTypeint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IInt32SingleTypeint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.int32inte0m m
LEFT JOIN dbo.int32inte0mi mi ON mi.id = m.int32inte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32intE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IInt32SingleTypeint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IInt32SingleTypeint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32intE0M), typeof(FlatInt32intE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                await((IInt32SingleTypeint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                ((IInt32SingleTypeint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32intE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.int32inte0m m
LEFT JOIN dbo.int32inte0mi mi ON mi.id = m.int32inte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32intE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32intE0M), typeof(FlatInt32intE0M)],
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                await((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 174;
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 156;
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 177;
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32intE0M)],
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
FROM dbo.int32inte0m m
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
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 183;
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt32intE0M.AssertModel(models[0],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt32intE0M.AssertModel(models[0],_testData[6], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[7], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[8], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[9], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[10], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[11], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[12], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[13], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[14], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[15], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[19],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[20],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[21],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[22],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[23],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[24],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[25],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[26],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[27],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM dbo.int32inte0m m
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
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt32intE0M.AssertModel(models[0],_testData[7], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[8], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[9], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[10], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[11], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[12], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[13], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[14], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[15], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[19],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[20],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[21],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[22],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[23],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[24],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[25],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[26],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt32intE0M.AssertModel(models[0],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 180;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM dbo.int32inte0m m
LEFT JOIN dbo.int32inte0mi mi ON mi.id = m.int32inte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32intE0M)],
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int32intE0M.AssertModel(models[0],_testData[24], false);
                        Int32intE0M.AssertModel(models[1],_testData[25], false);
                        Int32intE0M.AssertModel(models[2],_testData[26], false);
                        Int32intE0M.AssertModel(models[3],_testData[27], false);
                        Int32intE0M.AssertModel(models[4],_testData[28], false);
                        Int32intE0M.AssertModel(models[5],_testData[29], false);
                        Int32intE0M.AssertModel(models[6],_testData[30], false);
                        Int32intE0M.AssertModel(models[7],_testData[31], false);
                        Int32intE0M.AssertModel(models[8],_testData[32], false);
                        Int32intE0M.AssertModel(models[9],_testData[33], false);
                        Int32intE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int32intE0M.AssertModel(models[0],_testData[10], false);
                        Int32intE0M.AssertModel(models[1],_testData[11], false);
                        Int32intE0M.AssertModel(models[2],_testData[12], false);
                        Int32intE0M.AssertModel(models[3],_testData[13], false);
                        Int32intE0M.AssertModel(models[4],_testData[14], false);
                        Int32intE0M.AssertModel(models[5],_testData[15], false);
                        Int32intE0M.AssertModel(models[6],_testData[16], false);
                        Int32intE0M.AssertModel(models[7],_testData[17], false);
                        Int32intE0M.AssertModel(models[8],_testData[18], false);
                        Int32intE0M.AssertModel(models[9],_testData[19], false);
                        Int32intE0M.AssertModel(models[10],_testData[20], false);
                        Int32intE0M.AssertModel(models[11],_testData[21], false);
                        Int32intE0M.AssertModel(models[12],_testData[22], false);
                        Int32intE0M.AssertModel(models[13],_testData[23], false);
                        Int32intE0M.AssertModel(models[14],_testData[24], false);
                        Int32intE0M.AssertModel(models[15],_testData[25], false);
                        Int32intE0M.AssertModel(models[16],_testData[26], false);
                        Int32intE0M.AssertModel(models[17],_testData[27], false);
                        Int32intE0M.AssertModel(models[18],_testData[28], false);
                        Int32intE0M.AssertModel(models[19],_testData[29], false);
                        Int32intE0M.AssertModel(models[20],_testData[30], false);
                        Int32intE0M.AssertModel(models[21],_testData[31], false);
                        Int32intE0M.AssertModel(models[22],_testData[32], false);
                        Int32intE0M.AssertModel(models[23],_testData[33], false);
                        Int32intE0M.AssertModel(models[24],_testData[34], false);
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 183;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int32intE0M.AssertModel(models[0],_testData[33], false);
                        Int32intE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int32intE0M.AssertModel(models[0],_testData[23], false);
                        Int32intE0M.AssertModel(models[1],_testData[24], false);
                        Int32intE0M.AssertModel(models[2],_testData[25], false);
                        Int32intE0M.AssertModel(models[3],_testData[26], false);
                        Int32intE0M.AssertModel(models[4],_testData[27], false);
                        Int32intE0M.AssertModel(models[5],_testData[28], false);
                        Int32intE0M.AssertModel(models[6],_testData[29], false);
                        Int32intE0M.AssertModel(models[7],_testData[30], false);
                        Int32intE0M.AssertModel(models[8],_testData[31], false);
                        Int32intE0M.AssertModel(models[9],_testData[32], false);
                        Int32intE0M.AssertModel(models[10],_testData[33], false);
                        Int32intE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32intE0M), typeof(FlatInt32intE0M)],
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
            dbType: (System.Data.DbType)11)]
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                await((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 146, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 38, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 117, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 58, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32intE0M)],
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
            dbType: (System.Data.DbType)11)]
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 177, query1, 153, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32intE0M.AssertModel(models[0],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt32intE0M.AssertModel(models[0],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[34], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 181, query1, 156, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 74, query1, 98, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt32intE0M.AssertModel(models[0],_testData[11], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[12], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[13], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[14], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[15], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[19],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[20],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[21],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[22],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt32intE0M.AssertModel(models[0],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[34], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatch(connection, 174, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM dbo.int32inte0m m
LEFT JOIN dbo.int32inte0mi mi ON mi.id = m.int32inte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32intE0M)],
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
            dbType: (System.Data.DbType)11)]
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatchAsync(connection, 98, 174))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int32intE0M.AssertModel(models[0],_testData[16], false);
                        Int32intE0M.AssertModel(models[1],_testData[17], false);
                        Int32intE0M.AssertModel(models[2],_testData[18], false);
                        Int32intE0M.AssertModel(models[3],_testData[19], false);
                        Int32intE0M.AssertModel(models[4],_testData[20], false);
                        Int32intE0M.AssertModel(models[5],_testData[21], false);
                        Int32intE0M.AssertModel(models[6],_testData[22], false);
                        Int32intE0M.AssertModel(models[7],_testData[23], false);
                        Int32intE0M.AssertModel(models[8],_testData[24], false);
                        Int32intE0M.AssertModel(models[9],_testData[25], false);
                        Int32intE0M.AssertModel(models[10],_testData[26], false);
                        Int32intE0M.AssertModel(models[11],_testData[27], false);
                        Int32intE0M.AssertModel(models[12],_testData[28], false);
                        Int32intE0M.AssertModel(models[13],_testData[29], false);
                        Int32intE0M.AssertModel(models[14],_testData[30], false);
                        Int32intE0M.AssertModel(models[15],_testData[31], false);
                        Int32intE0M.AssertModel(models[16],_testData[32], false);
                        Int32intE0M.AssertModel(models[17],_testData[33], false);
                        Int32intE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int32intE0M.AssertModel(models[0],_testData[29], false);
                        Int32intE0M.AssertModel(models[1],_testData[30], false);
                        Int32intE0M.AssertModel(models[2],_testData[31], false);
                        Int32intE0M.AssertModel(models[3],_testData[32], false);
                        Int32intE0M.AssertModel(models[4],_testData[33], false);
                        Int32intE0M.AssertModel(models[5],_testData[34], false);
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
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatch(connection, 177, 162))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int32intE0M.AssertModel(models[0],_testData[30], false);
                        Int32intE0M.AssertModel(models[1],_testData[31], false);
                        Int32intE0M.AssertModel(models[2],_testData[32], false);
                        Int32intE0M.AssertModel(models[3],_testData[33], false);
                        Int32intE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int32intE0M.AssertModel(models[0],_testData[27], false);
                        Int32intE0M.AssertModel(models[1],_testData[28], false);
                        Int32intE0M.AssertModel(models[2],_testData[29], false);
                        Int32intE0M.AssertModel(models[3],_testData[30], false);
                        Int32intE0M.AssertModel(models[4],_testData[31], false);
                        Int32intE0M.AssertModel(models[5],_testData[32], false);
                        Int32intE0M.AssertModel(models[6],_testData[33], false);
                        Int32intE0M.AssertModel(models[7],_testData[34], false);
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
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 18);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                Int32intE0M.AssertModel(models[0],_testData[2], false);
                Int32intE0M.AssertModel(models[1],_testData[3], false);
                Int32intE0M.AssertModel(models[2],_testData[4], false);
                Int32intE0M.AssertModel(models[3],_testData[5], false);
                Int32intE0M.AssertModel(models[4],_testData[6], false);
                Int32intE0M.AssertModel(models[5],_testData[7], false);
                Int32intE0M.AssertModel(models[6],_testData[8], false);
                Int32intE0M.AssertModel(models[7],_testData[9], false);
                Int32intE0M.AssertModel(models[8],_testData[10], false);
                Int32intE0M.AssertModel(models[9],_testData[11], false);
                Int32intE0M.AssertModel(models[10],_testData[12], false);
                Int32intE0M.AssertModel(models[11],_testData[13], false);
                Int32intE0M.AssertModel(models[12],_testData[14], false);
                Int32intE0M.AssertModel(models[13],_testData[15], false);
                Int32intE0M.AssertModel(models[14],_testData[16], false);
                Int32intE0M.AssertModel(models[15],_testData[17], false);
                Int32intE0M.AssertModel(models[16],_testData[18], false);
                Int32intE0M.AssertModel(models[17],_testData[19], false);
                Int32intE0M.AssertModel(models[18],_testData[20], false);
                Int32intE0M.AssertModel(models[19],_testData[21], false);
                Int32intE0M.AssertModel(models[20],_testData[22], false);
                Int32intE0M.AssertModel(models[21],_testData[23], false);
                Int32intE0M.AssertModel(models[22],_testData[24], false);
                Int32intE0M.AssertModel(models[23],_testData[25], false);
                Int32intE0M.AssertModel(models[24],_testData[26], false);
                Int32intE0M.AssertModel(models[25],_testData[27], false);
                Int32intE0M.AssertModel(models[26],_testData[28], false);
                Int32intE0M.AssertModel(models[27],_testData[29], false);
                Int32intE0M.AssertModel(models[28],_testData[30], false);
                Int32intE0M.AssertModel(models[29],_testData[31], false);
                Int32intE0M.AssertModel(models[30],_testData[32], false);
                Int32intE0M.AssertModel(models[31],_testData[33], false);
                Int32intE0M.AssertModel(models[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 174);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                Int32intE0M.AssertModel(models[0],_testData[29], false);
                Int32intE0M.AssertModel(models[1],_testData[30], false);
                Int32intE0M.AssertModel(models[2],_testData[31], false);
                Int32intE0M.AssertModel(models[3],_testData[32], false);
                Int32intE0M.AssertModel(models[4],_testData[33], false);
                Int32intE0M.AssertModel(models[5],_testData[34], false);
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
FROM dbo.int32inte0m m
LEFT JOIN dbo.int32inte0mi mi ON mi.id = m.int32inte0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1083835304)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1505920864)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1627342726)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((146268894)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((234467337)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1601333160)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((722171777)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((856245861)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((143562741)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1482749341)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((664101243)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((865105372)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1587045791)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((858200908)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1252716598)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1923177307)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((280555827)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((889583465)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1571959604)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1603726101)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((956054356)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1981962582)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((565254386)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1999173762)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((484558864)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((849884320)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1566069862)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((704636241)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((582705557)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1187625257)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2003224059)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1109399650)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((948550307)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1428079623)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1782735580)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((251773046)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1823385)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1066564731)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2114155909)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((219591127)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1883467087)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1437274433)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((183244218)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1672263349)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1834323800)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1453404247)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1624953616)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((2111134466)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((539846370)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((155133257)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((799186262)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((607128244)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1901788108)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1652593733)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1532376504)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((373782622)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((758859538)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1965007784)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1465350593)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1180561055)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1983747067)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((691519492)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1854758254)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1905834342)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((988412034)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((834839823)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1315564193)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((4957151)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1800050064)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((306043728)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1761479593)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((522068153)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1061640307)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1532738748)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1030550190)));//Value

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
                var models =  ((IInt32SingleTypeint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1083835304)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1505920864)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1627342726)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((146268894)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((234467337)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1601333160)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((722171777)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((856245861)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((143562741)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1482749341)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((664101243)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((865105372)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1587045791)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((858200908)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1252716598)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1923177307)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((280555827)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((889583465)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1571959604)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1603726101)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((956054356)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1981962582)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((565254386)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1999173762)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((484558864)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((849884320)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1566069862)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((704636241)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((582705557)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1187625257)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2003224059)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1109399650)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((948550307)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1428079623)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1782735580)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((251773046)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1823385)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1066564731)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2114155909)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((219591127)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1883467087)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1437274433)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((183244218)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1672263349)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1834323800)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1453404247)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1624953616)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((2111134466)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((539846370)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((155133257)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((799186262)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((607128244)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1901788108)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1652593733)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1532376504)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((373782622)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((758859538)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1965007784)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1465350593)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1180561055)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1983747067)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((691519492)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1854758254)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1905834342)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((988412034)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((834839823)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1315564193)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((4957151)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1800050064)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((306043728)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1761479593)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((522068153)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1061640307)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1532738748)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1030550190)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

