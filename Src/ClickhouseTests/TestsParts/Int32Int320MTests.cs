

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
    Id = 9,
    Value = 1241583724,
    ModelInner = new Int32Int320MI
{
    Id = 3,
    Value = 1969256922,
    NullableValue = null,
},
    NullableValue = 537561768,
},
            new Int32Int320M
{
    Id = 10,
    Value = 512247578,
    ModelInner = new Int32Int320MI
{
    Id = 4,
    Value = 67861830,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 11,
    Value = 222403433,
    ModelInner = new Int32Int320MI
{
    Id = 9,
    Value = 181178147,
    NullableValue = 204213164,
},
    NullableValue = 1716073066,
},
            new Int32Int320M
{
    Id = 16,
    Value = 777219385,
    ModelInner = new Int32Int320MI
{
    Id = 18,
    Value = 1252225312,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 22,
    Value = 2074007593,
    ModelInner = new Int32Int320MI
{
    Id = 26,
    Value = 541176366,
    NullableValue = 1170969084,
},
    NullableValue = 7319770,
},
            new Int32Int320M
{
    Id = 26,
    Value = 659301513,
    ModelInner = new Int32Int320MI
{
    Id = 35,
    Value = 457012473,
    NullableValue = null,
},
    NullableValue = 494189607,
},
            new Int32Int320M
{
    Id = 35,
    Value = 1932318402,
    ModelInner = new Int32Int320MI
{
    Id = 37,
    Value = 842789308,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 37,
    Value = 1672613716,
    ModelInner = new Int32Int320MI
{
    Id = 41,
    Value = 2043297730,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 46,
    Value = 1379125187,
    ModelInner = new Int32Int320MI
{
    Id = 43,
    Value = 1353840639,
    NullableValue = 706575024,
},
    NullableValue = 774889458,
},
            new Int32Int320M
{
    Id = 50,
    Value = 174659825,
    ModelInner = new Int32Int320MI
{
    Id = 48,
    Value = 1592977630,
    NullableValue = 1343893004,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 55,
    Value = 2102405969,
    ModelInner = new Int32Int320MI
{
    Id = 57,
    Value = 442039208,
    NullableValue = 210492976,
},
    NullableValue = 1339816981,
},
            new Int32Int320M
{
    Id = 63,
    Value = 1591231413,
    ModelInner = new Int32Int320MI
{
    Id = 63,
    Value = 804287895,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 65,
    Value = 1664293212,
    ModelInner = new Int32Int320MI
{
    Id = 67,
    Value = 571118930,
    NullableValue = 913790086,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 70,
    Value = 1688051098,
    ModelInner = new Int32Int320MI
{
    Id = 70,
    Value = 2129366832,
    NullableValue = null,
},
    NullableValue = 308183262,
},
            new Int32Int320M
{
    Id = 78,
    Value = 859338146,
    ModelInner = new Int32Int320MI
{
    Id = 73,
    Value = 838528629,
    NullableValue = 711348569,
},
    NullableValue = 1445360161,
},
            new Int32Int320M
{
    Id = 79,
    Value = 1075226461,
    ModelInner = new Int32Int320MI
{
    Id = 79,
    Value = 1751201745,
    NullableValue = 1401882636,
},
    NullableValue = 167633172,
},
            new Int32Int320M
{
    Id = 88,
    Value = 945195051,
    ModelInner = new Int32Int320MI
{
    Id = 84,
    Value = 1217262675,
    NullableValue = null,
},
    NullableValue = 117991514,
},
            new Int32Int320M
{
    Id = 91,
    Value = 861236439,
    ModelInner = new Int32Int320MI
{
    Id = 90,
    Value = 453405187,
    NullableValue = 1160598707,
},
    NullableValue = 581999926,
},
            new Int32Int320M
{
    Id = 98,
    Value = 522897869,
    ModelInner = new Int32Int320MI
{
    Id = 98,
    Value = 766945422,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 99,
    Value = 501109239,
    ModelInner = new Int32Int320MI
{
    Id = 101,
    Value = 1111586267,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 102,
    Value = 603059141,
    ModelInner = new Int32Int320MI
{
    Id = 110,
    Value = 569407691,
    NullableValue = 1845494554,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 110,
    Value = 552664155,
    ModelInner = new Int32Int320MI
{
    Id = 117,
    Value = 1447759307,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 119,
    Value = 1656285449,
    ModelInner = new Int32Int320MI
{
    Id = 123,
    Value = 1089228283,
    NullableValue = 1887896824,
},
    NullableValue = 645134627,
},
            new Int32Int320M
{
    Id = 125,
    Value = 991162992,
    ModelInner = new Int32Int320MI
{
    Id = 129,
    Value = 1684653685,
    NullableValue = null,
},
    NullableValue = 1264199476,
},
            new Int32Int320M
{
    Id = 133,
    Value = 902950432,
    ModelInner = new Int32Int320MI
{
    Id = 134,
    Value = 1456959187,
    NullableValue = 682147520,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 135,
    Value = 641650350,
    ModelInner = new Int32Int320MI
{
    Id = 140,
    Value = 1520551054,
    NullableValue = 1293988153,
},
    NullableValue = 579635183,
},
            new Int32Int320M
{
    Id = 136,
    Value = 1480749870,
    ModelInner = new Int32Int320MI
{
    Id = 143,
    Value = 2055192064,
    NullableValue = 63452644,
},
    NullableValue = 19060416,
},
            new Int32Int320M
{
    Id = 145,
    Value = 496457104,
    ModelInner = new Int32Int320MI
{
    Id = 151,
    Value = 509785516,
    NullableValue = 1410108378,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 149,
    Value = 2033898071,
    ModelInner = new Int32Int320MI
{
    Id = 155,
    Value = 1675393779,
    NullableValue = 718908411,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 156,
    Value = 1072895332,
    ModelInner = new Int32Int320MI
{
    Id = 160,
    Value = 634027803,
    NullableValue = 302404414,
},
    NullableValue = 324321025,
},
            new Int32Int320M
{
    Id = 165,
    Value = 44982211,
    ModelInner = new Int32Int320MI
{
    Id = 164,
    Value = 1382598708,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 167,
    Value = 1414757314,
    ModelInner = new Int32Int320MI
{
    Id = 171,
    Value = 1860444844,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 169,
    Value = 152770515,
    ModelInner = new Int32Int320MI
{
    Id = 178,
    Value = 742226352,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 170,
    Value = 44454290,
    ModelInner = new Int32Int320MI
{
    Id = 180,
    Value = 694264067,
    NullableValue = 227463655,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 176,
    Value = 986958939,
    ModelInner = new Int32Int320MI
{
    Id = 181,
    Value = 753994702,
    NullableValue = 307070708,
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
                for (int i = 0; i < 2; i++)
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

