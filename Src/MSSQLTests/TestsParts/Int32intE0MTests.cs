

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
    Id = 1,
    Value = 1923470772,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 8,
    Value = 1908113338,
    ModelInner = new Int32intE0MI
{
    Id = 2,
    Value = 452744336,
    NullableValue = 778083188,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 9,
    Value = 1592245848,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 18,
    Value = 39810195,
    ModelInner = new Int32intE0MI
{
    Id = 11,
    Value = 941630674,
    NullableValue = 678932758,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 24,
    Value = 521928670,
    ModelInner = null,
    NullableValue = 1864034244,
},
            new Int32intE0M
{
    Id = 27,
    Value = 2019308725,
    ModelInner = new Int32intE0MI
{
    Id = 12,
    Value = 1553280733,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 30,
    Value = 1190107909,
    ModelInner = null,
    NullableValue = 860170142,
},
            new Int32intE0M
{
    Id = 33,
    Value = 855344898,
    ModelInner = new Int32intE0MI
{
    Id = 16,
    Value = 1862821595,
    NullableValue = null,
},
    NullableValue = 346524961,
},
            new Int32intE0M
{
    Id = 40,
    Value = 2119047630,
    ModelInner = null,
    NullableValue = 1384118706,
},
            new Int32intE0M
{
    Id = 43,
    Value = 280362045,
    ModelInner = new Int32intE0MI
{
    Id = 17,
    Value = 1895715095,
    NullableValue = null,
},
    NullableValue = 1159052867,
},
            new Int32intE0M
{
    Id = 46,
    Value = 2067008153,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 53,
    Value = 595574610,
    ModelInner = new Int32intE0MI
{
    Id = 24,
    Value = 632627218,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 61,
    Value = 1992436951,
    ModelInner = null,
    NullableValue = 2036724,
},
            new Int32intE0M
{
    Id = 63,
    Value = 154046249,
    ModelInner = new Int32intE0MI
{
    Id = 26,
    Value = 1953448750,
    NullableValue = null,
},
    NullableValue = 1907774546,
},
            new Int32intE0M
{
    Id = 72,
    Value = 316273829,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 77,
    Value = 1972414619,
    ModelInner = new Int32intE0MI
{
    Id = 28,
    Value = 1513089276,
    NullableValue = 535935998,
},
    NullableValue = 1327311781,
},
            new Int32intE0M
{
    Id = 81,
    Value = 1811559759,
    ModelInner = null,
    NullableValue = 245213575,
},
            new Int32intE0M
{
    Id = 90,
    Value = 608923398,
    ModelInner = new Int32intE0MI
{
    Id = 35,
    Value = 45102822,
    NullableValue = 1058003147,
},
    NullableValue = 1981487159,
},
            new Int32intE0M
{
    Id = 94,
    Value = 1862742805,
    ModelInner = null,
    NullableValue = 501054785,
},
            new Int32intE0M
{
    Id = 101,
    Value = 970028717,
    ModelInner = new Int32intE0MI
{
    Id = 41,
    Value = 384385046,
    NullableValue = null,
},
    NullableValue = 1819658767,
},
            new Int32intE0M
{
    Id = 107,
    Value = 129750711,
    ModelInner = null,
    NullableValue = 496006323,
},
            new Int32intE0M
{
    Id = 116,
    Value = 920785743,
    ModelInner = new Int32intE0MI
{
    Id = 43,
    Value = 1924730917,
    NullableValue = null,
},
    NullableValue = 941112991,
},
            new Int32intE0M
{
    Id = 118,
    Value = 1506918526,
    ModelInner = null,
    NullableValue = 1185703394,
},
            new Int32intE0M
{
    Id = 124,
    Value = 826165806,
    ModelInner = new Int32intE0MI
{
    Id = 47,
    Value = 1322687067,
    NullableValue = null,
},
    NullableValue = 1699575339,
},
            new Int32intE0M
{
    Id = 129,
    Value = 433479863,
    ModelInner = null,
    NullableValue = 1566791534,
},
            new Int32intE0M
{
    Id = 134,
    Value = 1057537168,
    ModelInner = new Int32intE0MI
{
    Id = 52,
    Value = 1624622429,
    NullableValue = 624111713,
},
    NullableValue = 231245465,
},
            new Int32intE0M
{
    Id = 142,
    Value = 1574215129,
    ModelInner = null,
    NullableValue = 703214923,
},
            new Int32intE0M
{
    Id = 150,
    Value = 1369794887,
    ModelInner = new Int32intE0MI
{
    Id = 61,
    Value = 1247439435,
    NullableValue = 73981717,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 152,
    Value = 750558663,
    ModelInner = null,
    NullableValue = 1956219708,
},
            new Int32intE0M
{
    Id = 161,
    Value = 1031127541,
    ModelInner = new Int32intE0MI
{
    Id = 62,
    Value = 77921638,
    NullableValue = 320044820,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 169,
    Value = 1326568586,
    ModelInner = null,
    NullableValue = 1341232829,
},
            new Int32intE0M
{
    Id = 177,
    Value = 1897117279,
    ModelInner = new Int32intE0MI
{
    Id = 66,
    Value = 364463068,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 183,
    Value = 1558923992,
    ModelInner = null,
    NullableValue = 2011998217,
},
            new Int32intE0M
{
    Id = 190,
    Value = 648879479,
    ModelInner = new Int32intE0MI
{
    Id = 71,
    Value = 1456512712,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 192,
    Value = 446859957,
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[34], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[27],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[34], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt32intE0M.AssertModel(models[0],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[34], false);
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
                parametr1.Value = 152;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt32intE0M.AssertModel(models[0],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[34], false);
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int32intE0M.AssertModel(models[0],_testData[32], false);
                        Int32intE0M.AssertModel(models[1],_testData[33], false);
                        Int32intE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int32intE0M.AssertModel(models[0],_testData[12], false);
                        Int32intE0M.AssertModel(models[1],_testData[13], false);
                        Int32intE0M.AssertModel(models[2],_testData[14], false);
                        Int32intE0M.AssertModel(models[3],_testData[15], false);
                        Int32intE0M.AssertModel(models[4],_testData[16], false);
                        Int32intE0M.AssertModel(models[5],_testData[17], false);
                        Int32intE0M.AssertModel(models[6],_testData[18], false);
                        Int32intE0M.AssertModel(models[7],_testData[19], false);
                        Int32intE0M.AssertModel(models[8],_testData[20], false);
                        Int32intE0M.AssertModel(models[9],_testData[21], false);
                        Int32intE0M.AssertModel(models[10],_testData[22], false);
                        Int32intE0M.AssertModel(models[11],_testData[23], false);
                        Int32intE0M.AssertModel(models[12],_testData[24], false);
                        Int32intE0M.AssertModel(models[13],_testData[25], false);
                        Int32intE0M.AssertModel(models[14],_testData[26], false);
                        Int32intE0M.AssertModel(models[15],_testData[27], false);
                        Int32intE0M.AssertModel(models[16],_testData[28], false);
                        Int32intE0M.AssertModel(models[17],_testData[29], false);
                        Int32intE0M.AssertModel(models[18],_testData[30], false);
                        Int32intE0M.AssertModel(models[19],_testData[31], false);
                        Int32intE0M.AssertModel(models[20],_testData[32], false);
                        Int32intE0M.AssertModel(models[21],_testData[33], false);
                        Int32intE0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int32intE0M.AssertModel(models[0],_testData[21], false);
                        Int32intE0M.AssertModel(models[1],_testData[22], false);
                        Int32intE0M.AssertModel(models[2],_testData[23], false);
                        Int32intE0M.AssertModel(models[3],_testData[24], false);
                        Int32intE0M.AssertModel(models[4],_testData[25], false);
                        Int32intE0M.AssertModel(models[5],_testData[26], false);
                        Int32intE0M.AssertModel(models[6],_testData[27], false);
                        Int32intE0M.AssertModel(models[7],_testData[28], false);
                        Int32intE0M.AssertModel(models[8],_testData[29], false);
                        Int32intE0M.AssertModel(models[9],_testData[30], false);
                        Int32intE0M.AssertModel(models[10],_testData[31], false);
                        Int32intE0M.AssertModel(models[11],_testData[32], false);
                        Int32intE0M.AssertModel(models[12],_testData[33], false);
                        Int32intE0M.AssertModel(models[13],_testData[34], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 8, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[34], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 61, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[34], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 43, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[34], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 124, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 169, query1, 129, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt32intE0M.AssertModel(models[0],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[34], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 1, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[15],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 63, query1, 177, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt32intE0M.AssertModel(models[0],_testData[14], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[15], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[19],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt32intE0M.AssertModel(models[0],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[34], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatch(connection, 77, query1, 177, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[34], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatchAsync(connection, 107, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int32intE0M.AssertModel(models[0],_testData[21], false);
                        Int32intE0M.AssertModel(models[1],_testData[22], false);
                        Int32intE0M.AssertModel(models[2],_testData[23], false);
                        Int32intE0M.AssertModel(models[3],_testData[24], false);
                        Int32intE0M.AssertModel(models[4],_testData[25], false);
                        Int32intE0M.AssertModel(models[5],_testData[26], false);
                        Int32intE0M.AssertModel(models[6],_testData[27], false);
                        Int32intE0M.AssertModel(models[7],_testData[28], false);
                        Int32intE0M.AssertModel(models[8],_testData[29], false);
                        Int32intE0M.AssertModel(models[9],_testData[30], false);
                        Int32intE0M.AssertModel(models[10],_testData[31], false);
                        Int32intE0M.AssertModel(models[11],_testData[32], false);
                        Int32intE0M.AssertModel(models[12],_testData[33], false);
                        Int32intE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int32intE0M.AssertModel(models[0],_testData[7], false);
                        Int32intE0M.AssertModel(models[1],_testData[8], false);
                        Int32intE0M.AssertModel(models[2],_testData[9], false);
                        Int32intE0M.AssertModel(models[3],_testData[10], false);
                        Int32intE0M.AssertModel(models[4],_testData[11], false);
                        Int32intE0M.AssertModel(models[5],_testData[12], false);
                        Int32intE0M.AssertModel(models[6],_testData[13], false);
                        Int32intE0M.AssertModel(models[7],_testData[14], false);
                        Int32intE0M.AssertModel(models[8],_testData[15], false);
                        Int32intE0M.AssertModel(models[9],_testData[16], false);
                        Int32intE0M.AssertModel(models[10],_testData[17], false);
                        Int32intE0M.AssertModel(models[11],_testData[18], false);
                        Int32intE0M.AssertModel(models[12],_testData[19], false);
                        Int32intE0M.AssertModel(models[13],_testData[20], false);
                        Int32intE0M.AssertModel(models[14],_testData[21], false);
                        Int32intE0M.AssertModel(models[15],_testData[22], false);
                        Int32intE0M.AssertModel(models[16],_testData[23], false);
                        Int32intE0M.AssertModel(models[17],_testData[24], false);
                        Int32intE0M.AssertModel(models[18],_testData[25], false);
                        Int32intE0M.AssertModel(models[19],_testData[26], false);
                        Int32intE0M.AssertModel(models[20],_testData[27], false);
                        Int32intE0M.AssertModel(models[21],_testData[28], false);
                        Int32intE0M.AssertModel(models[22],_testData[29], false);
                        Int32intE0M.AssertModel(models[23],_testData[30], false);
                        Int32intE0M.AssertModel(models[24],_testData[31], false);
                        Int32intE0M.AssertModel(models[25],_testData[32], false);
                        Int32intE0M.AssertModel(models[26],_testData[33], false);
                        Int32intE0M.AssertModel(models[27],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatch(connection, 1, 1))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int32intE0M.AssertModel(models[0],_testData[1], false);
                        Int32intE0M.AssertModel(models[1],_testData[2], false);
                        Int32intE0M.AssertModel(models[2],_testData[3], false);
                        Int32intE0M.AssertModel(models[3],_testData[4], false);
                        Int32intE0M.AssertModel(models[4],_testData[5], false);
                        Int32intE0M.AssertModel(models[5],_testData[6], false);
                        Int32intE0M.AssertModel(models[6],_testData[7], false);
                        Int32intE0M.AssertModel(models[7],_testData[8], false);
                        Int32intE0M.AssertModel(models[8],_testData[9], false);
                        Int32intE0M.AssertModel(models[9],_testData[10], false);
                        Int32intE0M.AssertModel(models[10],_testData[11], false);
                        Int32intE0M.AssertModel(models[11],_testData[12], false);
                        Int32intE0M.AssertModel(models[12],_testData[13], false);
                        Int32intE0M.AssertModel(models[13],_testData[14], false);
                        Int32intE0M.AssertModel(models[14],_testData[15], false);
                        Int32intE0M.AssertModel(models[15],_testData[16], false);
                        Int32intE0M.AssertModel(models[16],_testData[17], false);
                        Int32intE0M.AssertModel(models[17],_testData[18], false);
                        Int32intE0M.AssertModel(models[18],_testData[19], false);
                        Int32intE0M.AssertModel(models[19],_testData[20], false);
                        Int32intE0M.AssertModel(models[20],_testData[21], false);
                        Int32intE0M.AssertModel(models[21],_testData[22], false);
                        Int32intE0M.AssertModel(models[22],_testData[23], false);
                        Int32intE0M.AssertModel(models[23],_testData[24], false);
                        Int32intE0M.AssertModel(models[24],_testData[25], false);
                        Int32intE0M.AssertModel(models[25],_testData[26], false);
                        Int32intE0M.AssertModel(models[26],_testData[27], false);
                        Int32intE0M.AssertModel(models[27],_testData[28], false);
                        Int32intE0M.AssertModel(models[28],_testData[29], false);
                        Int32intE0M.AssertModel(models[29],_testData[30], false);
                        Int32intE0M.AssertModel(models[30],_testData[31], false);
                        Int32intE0M.AssertModel(models[31],_testData[32], false);
                        Int32intE0M.AssertModel(models[32],_testData[33], false);
                        Int32intE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int32intE0M.AssertModel(models[0],_testData[1], false);
                        Int32intE0M.AssertModel(models[1],_testData[2], false);
                        Int32intE0M.AssertModel(models[2],_testData[3], false);
                        Int32intE0M.AssertModel(models[3],_testData[4], false);
                        Int32intE0M.AssertModel(models[4],_testData[5], false);
                        Int32intE0M.AssertModel(models[5],_testData[6], false);
                        Int32intE0M.AssertModel(models[6],_testData[7], false);
                        Int32intE0M.AssertModel(models[7],_testData[8], false);
                        Int32intE0M.AssertModel(models[8],_testData[9], false);
                        Int32intE0M.AssertModel(models[9],_testData[10], false);
                        Int32intE0M.AssertModel(models[10],_testData[11], false);
                        Int32intE0M.AssertModel(models[11],_testData[12], false);
                        Int32intE0M.AssertModel(models[12],_testData[13], false);
                        Int32intE0M.AssertModel(models[13],_testData[14], false);
                        Int32intE0M.AssertModel(models[14],_testData[15], false);
                        Int32intE0M.AssertModel(models[15],_testData[16], false);
                        Int32intE0M.AssertModel(models[16],_testData[17], false);
                        Int32intE0M.AssertModel(models[17],_testData[18], false);
                        Int32intE0M.AssertModel(models[18],_testData[19], false);
                        Int32intE0M.AssertModel(models[19],_testData[20], false);
                        Int32intE0M.AssertModel(models[20],_testData[21], false);
                        Int32intE0M.AssertModel(models[21],_testData[22], false);
                        Int32intE0M.AssertModel(models[22],_testData[23], false);
                        Int32intE0M.AssertModel(models[23],_testData[24], false);
                        Int32intE0M.AssertModel(models[24],_testData[25], false);
                        Int32intE0M.AssertModel(models[25],_testData[26], false);
                        Int32intE0M.AssertModel(models[26],_testData[27], false);
                        Int32intE0M.AssertModel(models[27],_testData[28], false);
                        Int32intE0M.AssertModel(models[28],_testData[29], false);
                        Int32intE0M.AssertModel(models[29],_testData[30], false);
                        Int32intE0M.AssertModel(models[30],_testData[31], false);
                        Int32intE0M.AssertModel(models[31],_testData[32], false);
                        Int32intE0M.AssertModel(models[32],_testData[33], false);
                        Int32intE0M.AssertModel(models[33],_testData[34], false);
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
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                Int32intE0M.AssertModel(models[0],_testData[19], false);
                Int32intE0M.AssertModel(models[1],_testData[20], false);
                Int32intE0M.AssertModel(models[2],_testData[21], false);
                Int32intE0M.AssertModel(models[3],_testData[22], false);
                Int32intE0M.AssertModel(models[4],_testData[23], false);
                Int32intE0M.AssertModel(models[5],_testData[24], false);
                Int32intE0M.AssertModel(models[6],_testData[25], false);
                Int32intE0M.AssertModel(models[7],_testData[26], false);
                Int32intE0M.AssertModel(models[8],_testData[27], false);
                Int32intE0M.AssertModel(models[9],_testData[28], false);
                Int32intE0M.AssertModel(models[10],_testData[29], false);
                Int32intE0M.AssertModel(models[11],_testData[30], false);
                Int32intE0M.AssertModel(models[12],_testData[31], false);
                Int32intE0M.AssertModel(models[13],_testData[32], false);
                Int32intE0M.AssertModel(models[14],_testData[33], false);
                Int32intE0M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1923470772)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1908113338)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((452744336)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((778083188)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1592245848)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((39810195)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((941630674)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((678932758)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((521928670)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1864034244)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2019308725)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1553280733)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1190107909)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((860170142)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((855344898)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1862821595)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((346524961)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2119047630)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1384118706)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((280362045)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1895715095)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1159052867)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2067008153)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((595574610)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((632627218)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1992436951)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2036724)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((154046249)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1953448750)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1907774546)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((316273829)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1972414619)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1513089276)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((535935998)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1327311781)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1811559759)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((245213575)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((608923398)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((45102822)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1058003147)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1981487159)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1862742805)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((501054785)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((970028717)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((384385046)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1819658767)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((129750711)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((496006323)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((920785743)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1924730917)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((941112991)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1506918526)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1185703394)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((826165806)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1322687067)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1699575339)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((433479863)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1566791534)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1057537168)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1624622429)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((624111713)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((231245465)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1574215129)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((703214923)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1369794887)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1247439435)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((73981717)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((750558663)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1956219708)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1031127541)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((77921638)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((320044820)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1326568586)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1341232829)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1897117279)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((364463068)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1558923992)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2011998217)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((648879479)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1456512712)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((446859957)));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1923470772)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1908113338)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((452744336)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((778083188)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1592245848)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((39810195)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((941630674)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((678932758)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((521928670)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1864034244)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2019308725)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1553280733)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1190107909)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((860170142)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((855344898)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1862821595)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((346524961)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2119047630)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1384118706)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((280362045)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1895715095)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1159052867)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2067008153)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((595574610)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((632627218)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1992436951)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2036724)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((154046249)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1953448750)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1907774546)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((316273829)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1972414619)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1513089276)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((535935998)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1327311781)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1811559759)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((245213575)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((608923398)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((45102822)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1058003147)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1981487159)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1862742805)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((501054785)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((970028717)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((384385046)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1819658767)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((129750711)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((496006323)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((920785743)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1924730917)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((941112991)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1506918526)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1185703394)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((826165806)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1322687067)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1699575339)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((433479863)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1566791534)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1057537168)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1624622429)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((624111713)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((231245465)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1574215129)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((703214923)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1369794887)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1247439435)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((73981717)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((750558663)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1956219708)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1031127541)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((77921638)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((320044820)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1326568586)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1341232829)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1897117279)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((364463068)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1558923992)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2011998217)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((648879479)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1456512712)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((446859957)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

