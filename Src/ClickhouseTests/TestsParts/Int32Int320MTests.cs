

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
    Value = 371153148,
    ModelInner = new Int32Int320MI
{
    Id = 1,
    Value = 742258177,
    NullableValue = null,
},
    NullableValue = 1629817705,
},
            new Int32Int320M
{
    Id = 14,
    Value = 1858715949,
    ModelInner = new Int32Int320MI
{
    Id = 5,
    Value = 1459313252,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 20,
    Value = 1038782325,
    ModelInner = new Int32Int320MI
{
    Id = 13,
    Value = 406352228,
    NullableValue = null,
},
    NullableValue = 134957468,
},
            new Int32Int320M
{
    Id = 23,
    Value = 1303722417,
    ModelInner = new Int32Int320MI
{
    Id = 21,
    Value = 1601768479,
    NullableValue = null,
},
    NullableValue = 1152795528,
},
            new Int32Int320M
{
    Id = 26,
    Value = 1710692432,
    ModelInner = new Int32Int320MI
{
    Id = 30,
    Value = 1732513062,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 32,
    Value = 1675203174,
    ModelInner = new Int32Int320MI
{
    Id = 36,
    Value = 1629891906,
    NullableValue = 1604241054,
},
    NullableValue = 1675229855,
},
            new Int32Int320M
{
    Id = 36,
    Value = 895814307,
    ModelInner = new Int32Int320MI
{
    Id = 38,
    Value = 2050586226,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 40,
    Value = 835072162,
    ModelInner = new Int32Int320MI
{
    Id = 43,
    Value = 1539647438,
    NullableValue = 1875028998,
},
    NullableValue = 1373301513,
},
            new Int32Int320M
{
    Id = 49,
    Value = 2138388087,
    ModelInner = new Int32Int320MI
{
    Id = 52,
    Value = 108897314,
    NullableValue = 1491061718,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 57,
    Value = 849311490,
    ModelInner = new Int32Int320MI
{
    Id = 54,
    Value = 1137048118,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 66,
    Value = 542981120,
    ModelInner = new Int32Int320MI
{
    Id = 57,
    Value = 1317372531,
    NullableValue = 1494028341,
},
    NullableValue = 1026894711,
},
            new Int32Int320M
{
    Id = 68,
    Value = 685259800,
    ModelInner = new Int32Int320MI
{
    Id = 59,
    Value = 1035841352,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 69,
    Value = 66974293,
    ModelInner = new Int32Int320MI
{
    Id = 66,
    Value = 562875637,
    NullableValue = 1446090161,
},
    NullableValue = 767213242,
},
            new Int32Int320M
{
    Id = 71,
    Value = 764778285,
    ModelInner = new Int32Int320MI
{
    Id = 68,
    Value = 1142599387,
    NullableValue = null,
},
    NullableValue = 393734033,
},
            new Int32Int320M
{
    Id = 78,
    Value = 1615677208,
    ModelInner = new Int32Int320MI
{
    Id = 70,
    Value = 452735544,
    NullableValue = 1050542053,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 86,
    Value = 677445730,
    ModelInner = new Int32Int320MI
{
    Id = 77,
    Value = 251393148,
    NullableValue = null,
},
    NullableValue = 1608816078,
},
            new Int32Int320M
{
    Id = 94,
    Value = 2060723310,
    ModelInner = new Int32Int320MI
{
    Id = 80,
    Value = 1929315089,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 96,
    Value = 1408503485,
    ModelInner = new Int32Int320MI
{
    Id = 87,
    Value = 1785727143,
    NullableValue = 1942039945,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 103,
    Value = 1063747204,
    ModelInner = new Int32Int320MI
{
    Id = 88,
    Value = 1745774829,
    NullableValue = 888473425,
},
    NullableValue = 2041999768,
},
            new Int32Int320M
{
    Id = 106,
    Value = 15492972,
    ModelInner = new Int32Int320MI
{
    Id = 90,
    Value = 169592541,
    NullableValue = null,
},
    NullableValue = 18181921,
},
            new Int32Int320M
{
    Id = 110,
    Value = 1448744690,
    ModelInner = new Int32Int320MI
{
    Id = 97,
    Value = 2131420752,
    NullableValue = null,
},
    NullableValue = 1052469022,
},
            new Int32Int320M
{
    Id = 119,
    Value = 1713516934,
    ModelInner = new Int32Int320MI
{
    Id = 102,
    Value = 1611573168,
    NullableValue = 1701316079,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 128,
    Value = 1318353543,
    ModelInner = new Int32Int320MI
{
    Id = 109,
    Value = 601923817,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 134,
    Value = 659469869,
    ModelInner = new Int32Int320MI
{
    Id = 111,
    Value = 398511496,
    NullableValue = null,
},
    NullableValue = 611808897,
},
            new Int32Int320M
{
    Id = 136,
    Value = 1568942372,
    ModelInner = new Int32Int320MI
{
    Id = 117,
    Value = 290817321,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 138,
    Value = 1752151487,
    ModelInner = new Int32Int320MI
{
    Id = 120,
    Value = 1092243902,
    NullableValue = 1984986930,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 140,
    Value = 2066534537,
    ModelInner = new Int32Int320MI
{
    Id = 122,
    Value = 1471372342,
    NullableValue = null,
},
    NullableValue = 5642791,
},
            new Int32Int320M
{
    Id = 147,
    Value = 412805729,
    ModelInner = new Int32Int320MI
{
    Id = 131,
    Value = 1046526381,
    NullableValue = null,
},
    NullableValue = 1485285658,
},
            new Int32Int320M
{
    Id = 149,
    Value = 347013519,
    ModelInner = new Int32Int320MI
{
    Id = 139,
    Value = 1700928555,
    NullableValue = 892833084,
},
    NullableValue = 332673514,
},
            new Int32Int320M
{
    Id = 154,
    Value = 158309992,
    ModelInner = new Int32Int320MI
{
    Id = 147,
    Value = 1159846057,
    NullableValue = 1171939047,
},
    NullableValue = 91254917,
},
            new Int32Int320M
{
    Id = 157,
    Value = 1105660690,
    ModelInner = new Int32Int320MI
{
    Id = 152,
    Value = 168597348,
    NullableValue = 1149626807,
},
    NullableValue = 1398806999,
},
            new Int32Int320M
{
    Id = 159,
    Value = 1861387888,
    ModelInner = new Int32Int320MI
{
    Id = 156,
    Value = 1869065356,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 167,
    Value = 509570871,
    ModelInner = new Int32Int320MI
{
    Id = 163,
    Value = 781537922,
    NullableValue = 825110905,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 173,
    Value = 1507958502,
    ModelInner = new Int32Int320MI
{
    Id = 164,
    Value = 367727747,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 179,
    Value = 1221417513,
    ModelInner = new Int32Int320MI
{
    Id = 168,
    Value = 201031532,
    NullableValue = null,
},
    NullableValue = 420261361,
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
    {m_id:Int32},
    {m_value:Int32}, 
    {mi_id:Int32},
    {mi_value:Int32}
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
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 3; i++)
                {
                    await ((IInt32SingleTypeInt32)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IInt32SingleTypeInt32)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
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
    m_id = {m_id:Int32}
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
                methodParametrName: "m_id")]
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

