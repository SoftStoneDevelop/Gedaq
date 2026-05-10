

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

        private readonly UInt32UInt320M[] _testData = new UInt32UInt320M[]
        {
            new UInt32UInt320M
{
    Id = 5,
    Value = 3895244367,
    ModelInner = new UInt32UInt320MI
{
    Id = 2,
    Value = 2529010738,
    NullableValue = null,
},
    NullableValue = 3370235472,
},
            new UInt32UInt320M
{
    Id = 12,
    Value = 1825531744,
    ModelInner = new UInt32UInt320MI
{
    Id = 4,
    Value = 1937225171,
    NullableValue = 4015972733,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 14,
    Value = 1973865612,
    ModelInner = new UInt32UInt320MI
{
    Id = 7,
    Value = 171285136,
    NullableValue = null,
},
    NullableValue = 3833794638,
},
            new UInt32UInt320M
{
    Id = 22,
    Value = 2512393338,
    ModelInner = new UInt32UInt320MI
{
    Id = 12,
    Value = 1784476821,
    NullableValue = 1555376024,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 23,
    Value = 1234668558,
    ModelInner = new UInt32UInt320MI
{
    Id = 21,
    Value = 3046046486,
    NullableValue = 3453085779,
},
    NullableValue = 2945160247,
},
            new UInt32UInt320M
{
    Id = 30,
    Value = 3755793471,
    ModelInner = new UInt32UInt320MI
{
    Id = 28,
    Value = 3012698945,
    NullableValue = 2897287874,
},
    NullableValue = 3204796499,
},
            new UInt32UInt320M
{
    Id = 31,
    Value = 2177816051,
    ModelInner = new UInt32UInt320MI
{
    Id = 36,
    Value = 2387051687,
    NullableValue = 3264746654,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 37,
    Value = 3437343948,
    ModelInner = new UInt32UInt320MI
{
    Id = 44,
    Value = 2581872850,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 45,
    Value = 3077741663,
    ModelInner = new UInt32UInt320MI
{
    Id = 51,
    Value = 2056656204,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 53,
    Value = 4262890816,
    ModelInner = new UInt32UInt320MI
{
    Id = 55,
    Value = 2791708041,
    NullableValue = null,
},
    NullableValue = 2501847490,
},
            new UInt32UInt320M
{
    Id = 56,
    Value = 1138931153,
    ModelInner = new UInt32UInt320MI
{
    Id = 64,
    Value = 1224211743,
    NullableValue = 2349008353,
},
    NullableValue = 2526770207,
},
            new UInt32UInt320M
{
    Id = 58,
    Value = 1002244183,
    ModelInner = new UInt32UInt320MI
{
    Id = 70,
    Value = 1742232403,
    NullableValue = 3973582954,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 67,
    Value = 51944404,
    ModelInner = new UInt32UInt320MI
{
    Id = 73,
    Value = 4253817653,
    NullableValue = 3596782080,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 75,
    Value = 2590658091,
    ModelInner = new UInt32UInt320MI
{
    Id = 75,
    Value = 1185994614,
    NullableValue = 2818898785,
},
    NullableValue = 943490500,
},
            new UInt32UInt320M
{
    Id = 82,
    Value = 1815532435,
    ModelInner = new UInt32UInt320MI
{
    Id = 78,
    Value = 101471257,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 84,
    Value = 997560835,
    ModelInner = new UInt32UInt320MI
{
    Id = 82,
    Value = 2300510520,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 90,
    Value = 2396377855,
    ModelInner = new UInt32UInt320MI
{
    Id = 91,
    Value = 2659215530,
    NullableValue = 3147390923,
},
    NullableValue = 3083650547,
},
            new UInt32UInt320M
{
    Id = 97,
    Value = 1259718380,
    ModelInner = new UInt32UInt320MI
{
    Id = 97,
    Value = 4053672147,
    NullableValue = null,
},
    NullableValue = 1174675202,
},
            new UInt32UInt320M
{
    Id = 103,
    Value = 1295899651,
    ModelInner = new UInt32UInt320MI
{
    Id = 104,
    Value = 3649978305,
    NullableValue = 2826974357,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 111,
    Value = 1278374919,
    ModelInner = new UInt32UInt320MI
{
    Id = 111,
    Value = 3590723243,
    NullableValue = 1585598738,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 115,
    Value = 1938150652,
    ModelInner = new UInt32UInt320MI
{
    Id = 119,
    Value = 228506078,
    NullableValue = null,
},
    NullableValue = 1906987119,
},
            new UInt32UInt320M
{
    Id = 116,
    Value = 1051475012,
    ModelInner = new UInt32UInt320MI
{
    Id = 128,
    Value = 1913412020,
    NullableValue = 2435207065,
},
    NullableValue = 511588335,
},
            new UInt32UInt320M
{
    Id = 120,
    Value = 1655672596,
    ModelInner = new UInt32UInt320MI
{
    Id = 137,
    Value = 2907486675,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 123,
    Value = 2804502599,
    ModelInner = new UInt32UInt320MI
{
    Id = 141,
    Value = 4177764089,
    NullableValue = 2529203866,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 129,
    Value = 1593012027,
    ModelInner = new UInt32UInt320MI
{
    Id = 143,
    Value = 2447120251,
    NullableValue = 1252101199,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 135,
    Value = 2834539437,
    ModelInner = new UInt32UInt320MI
{
    Id = 149,
    Value = 3877758214,
    NullableValue = 4047477656,
},
    NullableValue = 3065957406,
},
            new UInt32UInt320M
{
    Id = 137,
    Value = 2216585659,
    ModelInner = new UInt32UInt320MI
{
    Id = 158,
    Value = 4007493417,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 139,
    Value = 2957726644,
    ModelInner = new UInt32UInt320MI
{
    Id = 161,
    Value = 1331538361,
    NullableValue = 2035869840,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 141,
    Value = 1955986026,
    ModelInner = new UInt32UInt320MI
{
    Id = 167,
    Value = 206664530,
    NullableValue = 4148102604,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 144,
    Value = 3703788389,
    ModelInner = new UInt32UInt320MI
{
    Id = 174,
    Value = 2240048495,
    NullableValue = 3386361826,
},
    NullableValue = 4012447371,
},
            new UInt32UInt320M
{
    Id = 152,
    Value = 459391681,
    ModelInner = new UInt32UInt320MI
{
    Id = 182,
    Value = 2496962442,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 155,
    Value = 2100157404,
    ModelInner = new UInt32UInt320MI
{
    Id = 191,
    Value = 3402232097,
    NullableValue = 2245318343,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 157,
    Value = 4093389745,
    ModelInner = new UInt32UInt320MI
{
    Id = 194,
    Value = 3059638809,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 162,
    Value = 1859987406,
    ModelInner = new UInt32UInt320MI
{
    Id = 197,
    Value = 945124987,
    NullableValue = null,
},
    NullableValue = 2014201140,
},
            new UInt32UInt320M
{
    Id = 171,
    Value = 2996670692,
    ModelInner = new UInt32UInt320MI
{
    Id = 203,
    Value = 1586249875,
    NullableValue = 3575481388,
},
    NullableValue = 2091421197,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint32uint320m(
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
FROM gedaqtests.uint32uint320m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32UInt320M)],
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
                    UInt32UInt320M.AssertModel(models[0],_testData[i], false);
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
                    UInt32UInt320M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

