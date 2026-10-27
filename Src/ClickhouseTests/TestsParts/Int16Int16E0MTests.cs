

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
    Id = 3,
    Value = 9841,
    ModelInner = new Int16Int16E0MI
{
    Id = 4,
    Value = 10038,
    NullableValue = 18129,
},
    NullableValue = 10318,
},
            new Int16Int16E0M
{
    Id = 11,
    Value = 10522,
    ModelInner = new Int16Int16E0MI
{
    Id = 8,
    Value = 2513,
    NullableValue = 28045,
},
    NullableValue = 9163,
},
            new Int16Int16E0M
{
    Id = 17,
    Value = 4344,
    ModelInner = new Int16Int16E0MI
{
    Id = 10,
    Value = 25717,
    NullableValue = null,
},
    NullableValue = 8491,
},
            new Int16Int16E0M
{
    Id = 21,
    Value = 32496,
    ModelInner = new Int16Int16E0MI
{
    Id = 13,
    Value = 13105,
    NullableValue = 29972,
},
    NullableValue = 20012,
},
            new Int16Int16E0M
{
    Id = 30,
    Value = 12590,
    ModelInner = new Int16Int16E0MI
{
    Id = 14,
    Value = 21751,
    NullableValue = 11470,
},
    NullableValue = 21077,
},
            new Int16Int16E0M
{
    Id = 36,
    Value = 21846,
    ModelInner = new Int16Int16E0MI
{
    Id = 17,
    Value = 12819,
    NullableValue = 20277,
},
    NullableValue = 24200,
},
            new Int16Int16E0M
{
    Id = 45,
    Value = 9938,
    ModelInner = new Int16Int16E0MI
{
    Id = 18,
    Value = 16063,
    NullableValue = null,
},
    NullableValue = 9522,
},
            new Int16Int16E0M
{
    Id = 46,
    Value = 7782,
    ModelInner = new Int16Int16E0MI
{
    Id = 21,
    Value = 24601,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 47,
    Value = 13765,
    ModelInner = new Int16Int16E0MI
{
    Id = 26,
    Value = 12636,
    NullableValue = 10360,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 51,
    Value = 30402,
    ModelInner = new Int16Int16E0MI
{
    Id = 34,
    Value = 451,
    NullableValue = null,
},
    NullableValue = 31827,
},
            new Int16Int16E0M
{
    Id = 53,
    Value = 8221,
    ModelInner = new Int16Int16E0MI
{
    Id = 42,
    Value = 31815,
    NullableValue = 17164,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 62,
    Value = 7899,
    ModelInner = new Int16Int16E0MI
{
    Id = 44,
    Value = 6380,
    NullableValue = 17017,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 67,
    Value = 32054,
    ModelInner = new Int16Int16E0MI
{
    Id = 50,
    Value = 13351,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 68,
    Value = 13012,
    ModelInner = new Int16Int16E0MI
{
    Id = 52,
    Value = 15488,
    NullableValue = null,
},
    NullableValue = 28157,
},
            new Int16Int16E0M
{
    Id = 75,
    Value = 12030,
    ModelInner = new Int16Int16E0MI
{
    Id = 60,
    Value = 10204,
    NullableValue = 11711,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 79,
    Value = 14853,
    ModelInner = new Int16Int16E0MI
{
    Id = 69,
    Value = 25420,
    NullableValue = null,
},
    NullableValue = 1236,
},
            new Int16Int16E0M
{
    Id = 87,
    Value = 11974,
    ModelInner = new Int16Int16E0MI
{
    Id = 76,
    Value = 19843,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 96,
    Value = 14488,
    ModelInner = new Int16Int16E0MI
{
    Id = 85,
    Value = 10318,
    NullableValue = 14546,
},
    NullableValue = 17937,
},
            new Int16Int16E0M
{
    Id = 102,
    Value = 9858,
    ModelInner = new Int16Int16E0MI
{
    Id = 88,
    Value = 21841,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 103,
    Value = 1950,
    ModelInner = new Int16Int16E0MI
{
    Id = 89,
    Value = 21918,
    NullableValue = 15066,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 107,
    Value = 2733,
    ModelInner = new Int16Int16E0MI
{
    Id = 93,
    Value = 8066,
    NullableValue = null,
},
    NullableValue = 5348,
},
            new Int16Int16E0M
{
    Id = 115,
    Value = 5385,
    ModelInner = new Int16Int16E0MI
{
    Id = 98,
    Value = 5059,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 121,
    Value = 15144,
    ModelInner = new Int16Int16E0MI
{
    Id = 99,
    Value = 699,
    NullableValue = null,
},
    NullableValue = 25871,
},
            new Int16Int16E0M
{
    Id = 126,
    Value = 1081,
    ModelInner = new Int16Int16E0MI
{
    Id = 105,
    Value = 4871,
    NullableValue = 28054,
},
    NullableValue = 9744,
},
            new Int16Int16E0M
{
    Id = 132,
    Value = 28945,
    ModelInner = new Int16Int16E0MI
{
    Id = 110,
    Value = 15695,
    NullableValue = 25562,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 138,
    Value = 14006,
    ModelInner = new Int16Int16E0MI
{
    Id = 117,
    Value = 7075,
    NullableValue = 9303,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 147,
    Value = 15582,
    ModelInner = new Int16Int16E0MI
{
    Id = 126,
    Value = 15658,
    NullableValue = null,
},
    NullableValue = 32550,
},
            new Int16Int16E0M
{
    Id = 150,
    Value = 24108,
    ModelInner = new Int16Int16E0MI
{
    Id = 132,
    Value = 15624,
    NullableValue = 30549,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 157,
    Value = 2941,
    ModelInner = new Int16Int16E0MI
{
    Id = 140,
    Value = 13772,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 162,
    Value = 30776,
    ModelInner = new Int16Int16E0MI
{
    Id = 143,
    Value = 11941,
    NullableValue = 19569,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 168,
    Value = 2909,
    ModelInner = new Int16Int16E0MI
{
    Id = 146,
    Value = 26271,
    NullableValue = null,
},
    NullableValue = 3214,
},
            new Int16Int16E0M
{
    Id = 173,
    Value = 22892,
    ModelInner = new Int16Int16E0MI
{
    Id = 148,
    Value = 9790,
    NullableValue = 6284,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 182,
    Value = 9190,
    ModelInner = new Int16Int16E0MI
{
    Id = 152,
    Value = 8363,
    NullableValue = null,
},
    NullableValue = 15138,
},
            new Int16Int16E0M
{
    Id = 190,
    Value = 24473,
    ModelInner = new Int16Int16E0MI
{
    Id = 159,
    Value = 23309,
    NullableValue = 20317,
},
    NullableValue = 29953,
},
            new Int16Int16E0M
{
    Id = 191,
    Value = 3237,
    ModelInner = new Int16Int16E0MI
{
    Id = 166,
    Value = 25552,
    NullableValue = null,
},
    NullableValue = 10715,
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

