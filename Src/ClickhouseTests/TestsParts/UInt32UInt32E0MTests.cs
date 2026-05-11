

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
    internal partial interface IUInt32SingleTypeUInt32
    {
    }
    
    internal partial class UInt32SingleTypeUInt32 : IUInt32SingleTypeUInt32
    {


#region TestData

        private readonly UInt32UInt32E0M[] _testData = new UInt32UInt32E0M[]
        {
            new UInt32UInt32E0M
{
    Id = 3,
    Value = 681971166,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 2,
    Value = 3195297560,
    NullableValue = 2014729927,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 6,
    Value = 1882384638,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 4,
    Value = 3586542899,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 10,
    Value = 1364632901,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 12,
    Value = 4053223711,
    NullableValue = 4003373727,
},
    NullableValue = 1567083655,
},
            new UInt32UInt32E0M
{
    Id = 17,
    Value = 3105745768,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 18,
    Value = 103346377,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 18,
    Value = 1510123813,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 26,
    Value = 794463785,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 27,
    Value = 3067861788,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 34,
    Value = 2081823566,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 30,
    Value = 1625946274,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 38,
    Value = 3721237543,
    NullableValue = 1873312747,
},
    NullableValue = 2224605860,
},
            new UInt32UInt32E0M
{
    Id = 37,
    Value = 1579554695,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 42,
    Value = 4128151921,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 41,
    Value = 1571762625,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 44,
    Value = 380288385,
    NullableValue = 3293351433,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 43,
    Value = 295388530,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 46,
    Value = 1129339418,
    NullableValue = 316221594,
},
    NullableValue = 3626582310,
},
            new UInt32UInt32E0M
{
    Id = 48,
    Value = 2250276641,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 50,
    Value = 3324994464,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 54,
    Value = 368572160,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 53,
    Value = 3777966784,
    NullableValue = null,
},
    NullableValue = 1807398988,
},
            new UInt32UInt32E0M
{
    Id = 56,
    Value = 2125068387,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 54,
    Value = 2651737708,
    NullableValue = 1690822312,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 62,
    Value = 3369869423,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 57,
    Value = 3229329660,
    NullableValue = 1824952080,
},
    NullableValue = 3599898711,
},
            new UInt32UInt32E0M
{
    Id = 69,
    Value = 946787865,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 65,
    Value = 755327526,
    NullableValue = null,
},
    NullableValue = 168719215,
},
            new UInt32UInt32E0M
{
    Id = 75,
    Value = 2651835221,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 69,
    Value = 1689451128,
    NullableValue = 1927309315,
},
    NullableValue = 2947552870,
},
            new UInt32UInt32E0M
{
    Id = 82,
    Value = 2504055019,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 74,
    Value = 2300629839,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 89,
    Value = 3218330157,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 83,
    Value = 4037668483,
    NullableValue = 986155751,
},
    NullableValue = 2789386426,
},
            new UInt32UInt32E0M
{
    Id = 98,
    Value = 3359217968,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 84,
    Value = 1373772691,
    NullableValue = 1376208775,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 102,
    Value = 2187173861,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 90,
    Value = 3902874006,
    NullableValue = 3836473906,
},
    NullableValue = 246481510,
},
            new UInt32UInt32E0M
{
    Id = 106,
    Value = 1384855839,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 97,
    Value = 1876659993,
    NullableValue = null,
},
    NullableValue = 2761598072,
},
            new UInt32UInt32E0M
{
    Id = 112,
    Value = 1926690609,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 104,
    Value = 240822096,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 120,
    Value = 944370190,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 105,
    Value = 44250995,
    NullableValue = null,
},
    NullableValue = 4282986306,
},
            new UInt32UInt32E0M
{
    Id = 127,
    Value = 1275633192,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 110,
    Value = 2266897975,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 130,
    Value = 1528725621,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 117,
    Value = 3511575116,
    NullableValue = null,
},
    NullableValue = 2865889705,
},
            new UInt32UInt32E0M
{
    Id = 133,
    Value = 1725450977,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 123,
    Value = 4002938111,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 135,
    Value = 884990540,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 131,
    Value = 1198493015,
    NullableValue = 2877704433,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 143,
    Value = 3720374094,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 136,
    Value = 1183293997,
    NullableValue = 2746296993,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 148,
    Value = 2639130894,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 138,
    Value = 389514530,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 156,
    Value = 3975557243,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 145,
    Value = 20571879,
    NullableValue = null,
},
    NullableValue = 3044682367,
},
            new UInt32UInt32E0M
{
    Id = 161,
    Value = 2009852182,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 148,
    Value = 3071313581,
    NullableValue = 3709154468,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 166,
    Value = 2187400234,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 155,
    Value = 2197935958,
    NullableValue = null,
},
    NullableValue = 3105273424,
},
            new UInt32UInt32E0M
{
    Id = 169,
    Value = 2470753563,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 158,
    Value = 1471456340,
    NullableValue = null,
},
    NullableValue = 3577050307,
},
            new UInt32UInt32E0M
{
    Id = 178,
    Value = 4034539936,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 164,
    Value = 942390461,
    NullableValue = 1075220416,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 183,
    Value = 3169724340,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 173,
    Value = 3983903558,
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
INSERT INTO gedaqtests.uint32uint32e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt32}, 
    {mi_id:Int32},
    {mi_value:UInt32}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeUInt32)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32), 
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
                    await ((IUInt32SingleTypeUInt32)this).InsertModelDbConnectionAsync(
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
                     ((IUInt32SingleTypeUInt32)this).InsertModelDbConnection(
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
FROM gedaqtests.uint32uint32e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32UInt32E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeUInt32)),
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
                    var models = await ((IUInt32SingleTypeUInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32UInt32E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt32SingleTypeUInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32UInt32E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

