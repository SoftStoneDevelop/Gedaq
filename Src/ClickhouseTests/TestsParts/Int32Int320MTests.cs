

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IInt32SingleTypeInt32
    {
    }
    
    internal partial class Int32SingleTypeInt32 : IInt32SingleTypeInt32
    {


#region TestData

        private readonly Int32Int320M[] _testData = new Int32Int320M[]
        {
            new Int32Int320M
{
    Id = 7,
    Value = 1081539581,
    ModelInner = new Int32Int320MI
{
    Id = 8,
    Value = 1190531200,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 10,
    Value = 1947663962,
    ModelInner = new Int32Int320MI
{
    Id = 9,
    Value = 1358594114,
    NullableValue = null,
},
    NullableValue = 28842141,
},
            new Int32Int320M
{
    Id = 17,
    Value = 1405456608,
    ModelInner = new Int32Int320MI
{
    Id = 11,
    Value = 1411622568,
    NullableValue = 1634573920,
},
    NullableValue = 607987970,
},
            new Int32Int320M
{
    Id = 23,
    Value = 1540982459,
    ModelInner = new Int32Int320MI
{
    Id = 13,
    Value = 208773689,
    NullableValue = 903328842,
},
    NullableValue = 1813890489,
},
            new Int32Int320M
{
    Id = 27,
    Value = 512431879,
    ModelInner = new Int32Int320MI
{
    Id = 18,
    Value = 1597708628,
    NullableValue = 1076759133,
},
    NullableValue = 1373443192,
},
            new Int32Int320M
{
    Id = 33,
    Value = 1237662928,
    ModelInner = new Int32Int320MI
{
    Id = 25,
    Value = 957025273,
    NullableValue = 1203351581,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 34,
    Value = 1932320506,
    ModelInner = new Int32Int320MI
{
    Id = 28,
    Value = 2063874707,
    NullableValue = null,
},
    NullableValue = 943997927,
},
            new Int32Int320M
{
    Id = 35,
    Value = 1840111126,
    ModelInner = new Int32Int320MI
{
    Id = 37,
    Value = 416022546,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 42,
    Value = 1461456287,
    ModelInner = new Int32Int320MI
{
    Id = 40,
    Value = 1401759182,
    NullableValue = 910599169,
},
    NullableValue = 1645998084,
},
            new Int32Int320M
{
    Id = 50,
    Value = 1568863410,
    ModelInner = new Int32Int320MI
{
    Id = 44,
    Value = 1330433097,
    NullableValue = 1413884722,
},
    NullableValue = 1916603965,
},
            new Int32Int320M
{
    Id = 52,
    Value = 1631941942,
    ModelInner = new Int32Int320MI
{
    Id = 52,
    Value = 1335767346,
    NullableValue = 1968174405,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 54,
    Value = 306026902,
    ModelInner = new Int32Int320MI
{
    Id = 56,
    Value = 1378554385,
    NullableValue = null,
},
    NullableValue = 923446467,
},
            new Int32Int320M
{
    Id = 58,
    Value = 1641014388,
    ModelInner = new Int32Int320MI
{
    Id = 65,
    Value = 439986105,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 62,
    Value = 1829500489,
    ModelInner = new Int32Int320MI
{
    Id = 74,
    Value = 964418353,
    NullableValue = 127238869,
},
    NullableValue = 1249505766,
},
            new Int32Int320M
{
    Id = 71,
    Value = 1066236485,
    ModelInner = new Int32Int320MI
{
    Id = 75,
    Value = 1269146127,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 76,
    Value = 1363183826,
    ModelInner = new Int32Int320MI
{
    Id = 76,
    Value = 1795501944,
    NullableValue = 86604775,
},
    NullableValue = 200154205,
},
            new Int32Int320M
{
    Id = 80,
    Value = 661980981,
    ModelInner = new Int32Int320MI
{
    Id = 82,
    Value = 1140907493,
    NullableValue = null,
},
    NullableValue = 1612263159,
},
            new Int32Int320M
{
    Id = 84,
    Value = 1083575153,
    ModelInner = new Int32Int320MI
{
    Id = 90,
    Value = 375142949,
    NullableValue = null,
},
    NullableValue = 1649419497,
},
            new Int32Int320M
{
    Id = 92,
    Value = 1163093486,
    ModelInner = new Int32Int320MI
{
    Id = 92,
    Value = 801857350,
    NullableValue = null,
},
    NullableValue = 1092009076,
},
            new Int32Int320M
{
    Id = 101,
    Value = 407590201,
    ModelInner = new Int32Int320MI
{
    Id = 96,
    Value = 218963248,
    NullableValue = 1237149910,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 105,
    Value = 945582942,
    ModelInner = new Int32Int320MI
{
    Id = 103,
    Value = 1009002462,
    NullableValue = 692203110,
},
    NullableValue = 904922249,
},
            new Int32Int320M
{
    Id = 113,
    Value = 1323901354,
    ModelInner = new Int32Int320MI
{
    Id = 111,
    Value = 624649248,
    NullableValue = 904316446,
},
    NullableValue = 795597992,
},
            new Int32Int320M
{
    Id = 122,
    Value = 276413175,
    ModelInner = new Int32Int320MI
{
    Id = 117,
    Value = 681653513,
    NullableValue = 1957479478,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 123,
    Value = 558350468,
    ModelInner = new Int32Int320MI
{
    Id = 125,
    Value = 844477177,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 125,
    Value = 53268134,
    ModelInner = new Int32Int320MI
{
    Id = 130,
    Value = 1159186496,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 132,
    Value = 1265600487,
    ModelInner = new Int32Int320MI
{
    Id = 135,
    Value = 1729182247,
    NullableValue = null,
},
    NullableValue = 1221633792,
},
            new Int32Int320M
{
    Id = 137,
    Value = 1437362216,
    ModelInner = new Int32Int320MI
{
    Id = 139,
    Value = 516042163,
    NullableValue = 769311907,
},
    NullableValue = 354006419,
},
            new Int32Int320M
{
    Id = 142,
    Value = 709838010,
    ModelInner = new Int32Int320MI
{
    Id = 146,
    Value = 748303401,
    NullableValue = 1641784944,
},
    NullableValue = 1676553876,
},
            new Int32Int320M
{
    Id = 143,
    Value = 1087212227,
    ModelInner = new Int32Int320MI
{
    Id = 149,
    Value = 1267456425,
    NullableValue = 1264499176,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 146,
    Value = 1033698587,
    ModelInner = new Int32Int320MI
{
    Id = 155,
    Value = 1736492616,
    NullableValue = null,
},
    NullableValue = 572007217,
},
            new Int32Int320M
{
    Id = 152,
    Value = 1540615060,
    ModelInner = new Int32Int320MI
{
    Id = 162,
    Value = 1672454744,
    NullableValue = 1200355009,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 155,
    Value = 1509031652,
    ModelInner = new Int32Int320MI
{
    Id = 170,
    Value = 1665600867,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 159,
    Value = 250276887,
    ModelInner = new Int32Int320MI
{
    Id = 175,
    Value = 1681930611,
    NullableValue = 770617534,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 167,
    Value = 1235367482,
    ModelInner = new Int32Int320MI
{
    Id = 178,
    Value = 1941840078,
    NullableValue = null,
},
    NullableValue = 1325286015,
},
            new Int32Int320M
{
    Id = 170,
    Value = 225832391,
    ModelInner = new Int32Int320MI
{
    Id = 181,
    Value = 714531866,
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int320m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    @m_id,
    @m_value, 
    @mi_id,
    @mi_value
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeInt32)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id", 
                dbType: (System.Data.DbType)(0)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_value", 
                methodParametrName: "m_Value", 
                dbType: (System.Data.DbType)(0)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id", 
                dbType: (System.Data.DbType)(0)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_Value", 
                methodParametrName: "mi_Value", 
                dbType: (System.Data.DbType)(0))]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IInt32SingleTypeInt32)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[0].Id,
                        m_Value: _testData[0].Value,
                        mi_Id: _testData[0].ModelInner.Id,
                        mi_Value: _testData[0].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 34; i++)
                {
                     ((IInt32SingleTypeInt32)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[2].Id,
                        m_Value: _testData[2].Value,
                        mi_Id: _testData[2].ModelInner.Id,
                        mi_Value: _testData[2].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT INTO gedaqtests.int32int320m(
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.int32int320m
WHERE
    m_id = @m_id
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int32Int320M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeInt32)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id", 
                dbType: (System.Data.DbType)(0))]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IInt32SingleTypeInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32Int320M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IInt32SingleTypeInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32Int320M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

