

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

        private readonly Int32Int32E0M[] _testData = new Int32Int32E0M[]
        {
            new Int32Int32E0M
{
    Id = 1,
    Value = 1340736945,
    ModelInner = new Int32Int32E0MI
{
    Id = 1,
    Value = 1652217100,
    NullableValue = null,
},
    NullableValue = 649007740,
},
            new Int32Int32E0M
{
    Id = 2,
    Value = 308134817,
    ModelInner = new Int32Int32E0MI
{
    Id = 7,
    Value = 481870590,
    NullableValue = null,
},
    NullableValue = 709722988,
},
            new Int32Int32E0M
{
    Id = 3,
    Value = 1882275949,
    ModelInner = new Int32Int32E0MI
{
    Id = 8,
    Value = 1333210508,
    NullableValue = 628898409,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 12,
    Value = 260506305,
    ModelInner = new Int32Int32E0MI
{
    Id = 14,
    Value = 1635180735,
    NullableValue = 1224462308,
},
    NullableValue = 1281169484,
},
            new Int32Int32E0M
{
    Id = 19,
    Value = 693453641,
    ModelInner = new Int32Int32E0MI
{
    Id = 20,
    Value = 1817569558,
    NullableValue = 1583725205,
},
    NullableValue = 42174161,
},
            new Int32Int32E0M
{
    Id = 20,
    Value = 1503918615,
    ModelInner = new Int32Int32E0MI
{
    Id = 22,
    Value = 1521340203,
    NullableValue = 156294756,
},
    NullableValue = 1306544818,
},
            new Int32Int32E0M
{
    Id = 29,
    Value = 1586696776,
    ModelInner = new Int32Int32E0MI
{
    Id = 28,
    Value = 982156877,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 34,
    Value = 632774726,
    ModelInner = new Int32Int32E0MI
{
    Id = 31,
    Value = 1065899548,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 42,
    Value = 1592908529,
    ModelInner = new Int32Int32E0MI
{
    Id = 33,
    Value = 381165414,
    NullableValue = 1649151028,
},
    NullableValue = 1932588154,
},
            new Int32Int32E0M
{
    Id = 50,
    Value = 1694837613,
    ModelInner = new Int32Int32E0MI
{
    Id = 37,
    Value = 763146522,
    NullableValue = null,
},
    NullableValue = 1588105276,
},
            new Int32Int32E0M
{
    Id = 59,
    Value = 554218025,
    ModelInner = new Int32Int32E0MI
{
    Id = 38,
    Value = 1691755265,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 66,
    Value = 735279236,
    ModelInner = new Int32Int32E0MI
{
    Id = 40,
    Value = 1086224695,
    NullableValue = null,
},
    NullableValue = 642584192,
},
            new Int32Int32E0M
{
    Id = 68,
    Value = 421811522,
    ModelInner = new Int32Int32E0MI
{
    Id = 42,
    Value = 859221665,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 75,
    Value = 1352166521,
    ModelInner = new Int32Int32E0MI
{
    Id = 48,
    Value = 1178623549,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 83,
    Value = 1505043095,
    ModelInner = new Int32Int32E0MI
{
    Id = 50,
    Value = 1293941055,
    NullableValue = 154594343,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 85,
    Value = 209131688,
    ModelInner = new Int32Int32E0MI
{
    Id = 58,
    Value = 1588437143,
    NullableValue = 417203473,
},
    NullableValue = 1969634552,
},
            new Int32Int32E0M
{
    Id = 93,
    Value = 1969334754,
    ModelInner = new Int32Int32E0MI
{
    Id = 66,
    Value = 891576986,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 95,
    Value = 1516012385,
    ModelInner = new Int32Int32E0MI
{
    Id = 67,
    Value = 1979632906,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 101,
    Value = 1995298836,
    ModelInner = new Int32Int32E0MI
{
    Id = 76,
    Value = 700704377,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 109,
    Value = 454201571,
    ModelInner = new Int32Int32E0MI
{
    Id = 80,
    Value = 866530437,
    NullableValue = null,
},
    NullableValue = 711967921,
},
            new Int32Int32E0M
{
    Id = 115,
    Value = 341103100,
    ModelInner = new Int32Int32E0MI
{
    Id = 85,
    Value = 866861461,
    NullableValue = null,
},
    NullableValue = 728856686,
},
            new Int32Int32E0M
{
    Id = 118,
    Value = 2078687553,
    ModelInner = new Int32Int32E0MI
{
    Id = 87,
    Value = 147500679,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 121,
    Value = 608789820,
    ModelInner = new Int32Int32E0MI
{
    Id = 95,
    Value = 1689669083,
    NullableValue = null,
},
    NullableValue = 1598260269,
},
            new Int32Int32E0M
{
    Id = 129,
    Value = 183675192,
    ModelInner = new Int32Int32E0MI
{
    Id = 101,
    Value = 853513161,
    NullableValue = 1927643371,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 133,
    Value = 1604496618,
    ModelInner = new Int32Int32E0MI
{
    Id = 108,
    Value = 592249538,
    NullableValue = null,
},
    NullableValue = 241167105,
},
            new Int32Int32E0M
{
    Id = 137,
    Value = 2142671708,
    ModelInner = new Int32Int32E0MI
{
    Id = 117,
    Value = 21742601,
    NullableValue = 1768634933,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 144,
    Value = 102148586,
    ModelInner = new Int32Int32E0MI
{
    Id = 118,
    Value = 33588272,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 153,
    Value = 600768960,
    ModelInner = new Int32Int32E0MI
{
    Id = 124,
    Value = 543872814,
    NullableValue = 606553389,
},
    NullableValue = 683576842,
},
            new Int32Int32E0M
{
    Id = 156,
    Value = 1826903717,
    ModelInner = new Int32Int32E0MI
{
    Id = 132,
    Value = 1787292906,
    NullableValue = 1329745758,
},
    NullableValue = 1870410823,
},
            new Int32Int32E0M
{
    Id = 161,
    Value = 400172114,
    ModelInner = new Int32Int32E0MI
{
    Id = 134,
    Value = 1210432845,
    NullableValue = 15426970,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 166,
    Value = 1840709077,
    ModelInner = new Int32Int32E0MI
{
    Id = 137,
    Value = 470021599,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 174,
    Value = 1363147069,
    ModelInner = new Int32Int32E0MI
{
    Id = 145,
    Value = 521331244,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 182,
    Value = 2001004105,
    ModelInner = new Int32Int32E0MI
{
    Id = 152,
    Value = 991918852,
    NullableValue = null,
},
    NullableValue = 1013777830,
},
            new Int32Int32E0M
{
    Id = 184,
    Value = 1658711199,
    ModelInner = new Int32Int32E0MI
{
    Id = 153,
    Value = 993488476,
    NullableValue = null,
},
    NullableValue = 1367136029,
},
            new Int32Int32E0M
{
    Id = 193,
    Value = 350137049,
    ModelInner = new Int32Int32E0MI
{
    Id = 154,
    Value = 1553115738,
    NullableValue = 1064732490,
},
    NullableValue = 657528036,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int32e0m(
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
FROM gedaqtests.int32int32e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int32Int32E0M)],
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
                    Int32Int32E0M.AssertModel(models[0],_testData[i], false);
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
                    Int32Int32E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

