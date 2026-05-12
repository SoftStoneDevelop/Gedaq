

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
    internal partial interface IInt16SingleTypeInt16
    {
    }
    
    internal partial class Int16SingleTypeInt16 : IInt16SingleTypeInt16
    {


#region TestData

        private readonly Int16Int16E0M[] _testData = new Int16Int16E0M[]
        {
            new Int16Int16E0M
{
    Id = 6,
    Value = 26331,
    ModelInner = new Int16Int16E0MI
{
    Id = 1,
    Value = 26422,
    NullableValue = 12871,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 12,
    Value = 15377,
    ModelInner = new Int16Int16E0MI
{
    Id = 7,
    Value = 5620,
    NullableValue = null,
},
    NullableValue = 20392,
},
            new Int16Int16E0M
{
    Id = 21,
    Value = 7341,
    ModelInner = new Int16Int16E0MI
{
    Id = 14,
    Value = 12829,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 28,
    Value = 15318,
    ModelInner = new Int16Int16E0MI
{
    Id = 20,
    Value = 4007,
    NullableValue = 18486,
},
    NullableValue = 14045,
},
            new Int16Int16E0M
{
    Id = 30,
    Value = 122,
    ModelInner = new Int16Int16E0MI
{
    Id = 24,
    Value = 1385,
    NullableValue = 19803,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 38,
    Value = 14771,
    ModelInner = new Int16Int16E0MI
{
    Id = 26,
    Value = 3894,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 46,
    Value = 13538,
    ModelInner = new Int16Int16E0MI
{
    Id = 27,
    Value = 10524,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 50,
    Value = 23346,
    ModelInner = new Int16Int16E0MI
{
    Id = 33,
    Value = 18318,
    NullableValue = null,
},
    NullableValue = 24526,
},
            new Int16Int16E0M
{
    Id = 58,
    Value = 26357,
    ModelInner = new Int16Int16E0MI
{
    Id = 39,
    Value = 18293,
    NullableValue = 7179,
},
    NullableValue = 29966,
},
            new Int16Int16E0M
{
    Id = 59,
    Value = 3755,
    ModelInner = new Int16Int16E0MI
{
    Id = 47,
    Value = 18339,
    NullableValue = 10637,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 60,
    Value = 21800,
    ModelInner = new Int16Int16E0MI
{
    Id = 56,
    Value = 2617,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 61,
    Value = 32510,
    ModelInner = new Int16Int16E0MI
{
    Id = 61,
    Value = 13523,
    NullableValue = 20922,
},
    NullableValue = 17422,
},
            new Int16Int16E0M
{
    Id = 70,
    Value = 15457,
    ModelInner = new Int16Int16E0MI
{
    Id = 64,
    Value = 28772,
    NullableValue = null,
},
    NullableValue = 27546,
},
            new Int16Int16E0M
{
    Id = 71,
    Value = 18703,
    ModelInner = new Int16Int16E0MI
{
    Id = 69,
    Value = 25025,
    NullableValue = null,
},
    NullableValue = 5896,
},
            new Int16Int16E0M
{
    Id = 72,
    Value = 6225,
    ModelInner = new Int16Int16E0MI
{
    Id = 73,
    Value = 16983,
    NullableValue = null,
},
    NullableValue = 3298,
},
            new Int16Int16E0M
{
    Id = 76,
    Value = 26487,
    ModelInner = new Int16Int16E0MI
{
    Id = 81,
    Value = 31262,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 77,
    Value = 13823,
    ModelInner = new Int16Int16E0MI
{
    Id = 83,
    Value = 2186,
    NullableValue = null,
},
    NullableValue = 16312,
},
            new Int16Int16E0M
{
    Id = 83,
    Value = 27900,
    ModelInner = new Int16Int16E0MI
{
    Id = 85,
    Value = 31806,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 91,
    Value = 31467,
    ModelInner = new Int16Int16E0MI
{
    Id = 92,
    Value = 20664,
    NullableValue = 31644,
},
    NullableValue = 23748,
},
            new Int16Int16E0M
{
    Id = 94,
    Value = 17309,
    ModelInner = new Int16Int16E0MI
{
    Id = 93,
    Value = 17778,
    NullableValue = null,
},
    NullableValue = 30758,
},
            new Int16Int16E0M
{
    Id = 103,
    Value = 32229,
    ModelInner = new Int16Int16E0MI
{
    Id = 97,
    Value = 2877,
    NullableValue = null,
},
    NullableValue = 21158,
},
            new Int16Int16E0M
{
    Id = 109,
    Value = 32710,
    ModelInner = new Int16Int16E0MI
{
    Id = 106,
    Value = 14207,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 110,
    Value = 7297,
    ModelInner = new Int16Int16E0MI
{
    Id = 114,
    Value = 8010,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 114,
    Value = 13162,
    ModelInner = new Int16Int16E0MI
{
    Id = 118,
    Value = 30639,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 118,
    Value = 23577,
    ModelInner = new Int16Int16E0MI
{
    Id = 124,
    Value = 16633,
    NullableValue = 14173,
},
    NullableValue = 16598,
},
            new Int16Int16E0M
{
    Id = 122,
    Value = 23366,
    ModelInner = new Int16Int16E0MI
{
    Id = 127,
    Value = 16353,
    NullableValue = 30345,
},
    NullableValue = 31679,
},
            new Int16Int16E0M
{
    Id = 127,
    Value = 19217,
    ModelInner = new Int16Int16E0MI
{
    Id = 131,
    Value = 30191,
    NullableValue = 18805,
},
    NullableValue = 28708,
},
            new Int16Int16E0M
{
    Id = 136,
    Value = 23738,
    ModelInner = new Int16Int16E0MI
{
    Id = 138,
    Value = 18136,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 141,
    Value = 6446,
    ModelInner = new Int16Int16E0MI
{
    Id = 139,
    Value = 27684,
    NullableValue = null,
},
    NullableValue = 23340,
},
            new Int16Int16E0M
{
    Id = 146,
    Value = 518,
    ModelInner = new Int16Int16E0MI
{
    Id = 146,
    Value = 373,
    NullableValue = 5142,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 151,
    Value = 3969,
    ModelInner = new Int16Int16E0MI
{
    Id = 154,
    Value = 30654,
    NullableValue = null,
},
    NullableValue = 8466,
},
            new Int16Int16E0M
{
    Id = 154,
    Value = 467,
    ModelInner = new Int16Int16E0MI
{
    Id = 156,
    Value = 17751,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 157,
    Value = 12397,
    ModelInner = new Int16Int16E0MI
{
    Id = 161,
    Value = 17396,
    NullableValue = 25520,
},
    NullableValue = 4195,
},
            new Int16Int16E0M
{
    Id = 160,
    Value = 22589,
    ModelInner = new Int16Int16E0MI
{
    Id = 167,
    Value = 7029,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 168,
    Value = 29766,
    ModelInner = new Int16Int16E0MI
{
    Id = 175,
    Value = 28328,
    NullableValue = 3476,
},
    NullableValue = 3025,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16int16e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Int16}, 
    {mi_id:Int32},
    {mi_value:Int16}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypeInt16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
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
                    await ((IInt16SingleTypeInt16)this).InsertModelDbConnectionAsync(
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
                     ((IInt16SingleTypeInt16)this).InsertModelDbConnection(
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
FROM gedaqtests.int16int16e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int16Int16E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypeInt16)),
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
                    var models = await ((IInt16SingleTypeInt16)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16Int16E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt16SingleTypeInt16)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16Int16E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

