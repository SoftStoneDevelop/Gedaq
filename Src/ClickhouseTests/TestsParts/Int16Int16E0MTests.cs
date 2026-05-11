

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
    Id = 4,
    Value = 22845,
    ModelInner = new Int16Int16E0MI
{
    Id = 2,
    Value = 5966,
    NullableValue = 22528,
},
    NullableValue = 14410,
},
            new Int16Int16E0M
{
    Id = 9,
    Value = 20025,
    ModelInner = new Int16Int16E0MI
{
    Id = 11,
    Value = 9140,
    NullableValue = null,
},
    NullableValue = 20393,
},
            new Int16Int16E0M
{
    Id = 16,
    Value = 26272,
    ModelInner = new Int16Int16E0MI
{
    Id = 20,
    Value = 7623,
    NullableValue = null,
},
    NullableValue = 12764,
},
            new Int16Int16E0M
{
    Id = 24,
    Value = 15639,
    ModelInner = new Int16Int16E0MI
{
    Id = 24,
    Value = 7310,
    NullableValue = 12578,
},
    NullableValue = 15798,
},
            new Int16Int16E0M
{
    Id = 30,
    Value = 21744,
    ModelInner = new Int16Int16E0MI
{
    Id = 25,
    Value = 1928,
    NullableValue = 31245,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 37,
    Value = 16012,
    ModelInner = new Int16Int16E0MI
{
    Id = 32,
    Value = 9527,
    NullableValue = 28431,
},
    NullableValue = 30940,
},
            new Int16Int16E0M
{
    Id = 39,
    Value = 15816,
    ModelInner = new Int16Int16E0MI
{
    Id = 38,
    Value = 1963,
    NullableValue = null,
},
    NullableValue = 26425,
},
            new Int16Int16E0M
{
    Id = 45,
    Value = 10547,
    ModelInner = new Int16Int16E0MI
{
    Id = 41,
    Value = 8337,
    NullableValue = 4432,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 46,
    Value = 32508,
    ModelInner = new Int16Int16E0MI
{
    Id = 48,
    Value = 20868,
    NullableValue = 13959,
},
    NullableValue = 15086,
},
            new Int16Int16E0M
{
    Id = 49,
    Value = 5106,
    ModelInner = new Int16Int16E0MI
{
    Id = 54,
    Value = 30850,
    NullableValue = 29965,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 55,
    Value = 20290,
    ModelInner = new Int16Int16E0MI
{
    Id = 55,
    Value = 15895,
    NullableValue = 2368,
},
    NullableValue = 32676,
},
            new Int16Int16E0M
{
    Id = 60,
    Value = 27700,
    ModelInner = new Int16Int16E0MI
{
    Id = 57,
    Value = 4243,
    NullableValue = null,
},
    NullableValue = 23053,
},
            new Int16Int16E0M
{
    Id = 68,
    Value = 32216,
    ModelInner = new Int16Int16E0MI
{
    Id = 62,
    Value = 25279,
    NullableValue = 13999,
},
    NullableValue = 10360,
},
            new Int16Int16E0M
{
    Id = 69,
    Value = 28826,
    ModelInner = new Int16Int16E0MI
{
    Id = 68,
    Value = 18540,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 78,
    Value = 26201,
    ModelInner = new Int16Int16E0MI
{
    Id = 75,
    Value = 14440,
    NullableValue = 16532,
},
    NullableValue = 23030,
},
            new Int16Int16E0M
{
    Id = 83,
    Value = 19180,
    ModelInner = new Int16Int16E0MI
{
    Id = 82,
    Value = 10354,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 90,
    Value = 24379,
    ModelInner = new Int16Int16E0MI
{
    Id = 89,
    Value = 21797,
    NullableValue = 13336,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 93,
    Value = 27655,
    ModelInner = new Int16Int16E0MI
{
    Id = 90,
    Value = 21302,
    NullableValue = null,
},
    NullableValue = 28307,
},
            new Int16Int16E0M
{
    Id = 95,
    Value = 22458,
    ModelInner = new Int16Int16E0MI
{
    Id = 92,
    Value = 23682,
    NullableValue = 21278,
},
    NullableValue = 7187,
},
            new Int16Int16E0M
{
    Id = 104,
    Value = 4086,
    ModelInner = new Int16Int16E0MI
{
    Id = 93,
    Value = 32581,
    NullableValue = 21273,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 107,
    Value = 22986,
    ModelInner = new Int16Int16E0MI
{
    Id = 101,
    Value = 16314,
    NullableValue = null,
},
    NullableValue = 11113,
},
            new Int16Int16E0M
{
    Id = 115,
    Value = 21896,
    ModelInner = new Int16Int16E0MI
{
    Id = 106,
    Value = 6639,
    NullableValue = 16166,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 124,
    Value = 13360,
    ModelInner = new Int16Int16E0MI
{
    Id = 110,
    Value = 27289,
    NullableValue = 12625,
},
    NullableValue = 28519,
},
            new Int16Int16E0M
{
    Id = 127,
    Value = 2076,
    ModelInner = new Int16Int16E0MI
{
    Id = 116,
    Value = 12856,
    NullableValue = 16338,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 130,
    Value = 521,
    ModelInner = new Int16Int16E0MI
{
    Id = 123,
    Value = 4521,
    NullableValue = null,
},
    NullableValue = 8750,
},
            new Int16Int16E0M
{
    Id = 135,
    Value = 30125,
    ModelInner = new Int16Int16E0MI
{
    Id = 125,
    Value = 3971,
    NullableValue = 30763,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 142,
    Value = 6094,
    ModelInner = new Int16Int16E0MI
{
    Id = 134,
    Value = 13304,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 143,
    Value = 20116,
    ModelInner = new Int16Int16E0MI
{
    Id = 138,
    Value = 15653,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 147,
    Value = 722,
    ModelInner = new Int16Int16E0MI
{
    Id = 139,
    Value = 16789,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 151,
    Value = 17939,
    ModelInner = new Int16Int16E0MI
{
    Id = 148,
    Value = 16999,
    NullableValue = 24905,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 160,
    Value = 1300,
    ModelInner = new Int16Int16E0MI
{
    Id = 155,
    Value = 23966,
    NullableValue = 2157,
},
    NullableValue = 24259,
},
            new Int16Int16E0M
{
    Id = 169,
    Value = 14810,
    ModelInner = new Int16Int16E0MI
{
    Id = 162,
    Value = 5019,
    NullableValue = null,
},
    NullableValue = 29483,
},
            new Int16Int16E0M
{
    Id = 171,
    Value = 32046,
    ModelInner = new Int16Int16E0MI
{
    Id = 163,
    Value = 14004,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 175,
    Value = 22218,
    ModelInner = new Int16Int16E0MI
{
    Id = 165,
    Value = 1417,
    NullableValue = null,
},
    NullableValue = 10374,
},
            new Int16Int16E0M
{
    Id = 183,
    Value = 32143,
    ModelInner = new Int16Int16E0MI
{
    Id = 172,
    Value = 13931,
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

