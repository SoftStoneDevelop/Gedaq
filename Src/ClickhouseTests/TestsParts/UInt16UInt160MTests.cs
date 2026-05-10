

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
    internal partial interface IUInt16SingleTypeUInt16
    {
    }
    
    internal partial class UInt16SingleTypeUInt16 : IUInt16SingleTypeUInt16
    {


#region TestData

        private readonly UInt16UInt160M[] _testData = new UInt16UInt160M[]
        {
            new UInt16UInt160M
{
    Id = 1,
    Value = 7304,
    ModelInner = new UInt16UInt160MI
{
    Id = 3,
    Value = 62658,
    NullableValue = null,
},
    NullableValue = 35321,
},
            new UInt16UInt160M
{
    Id = 7,
    Value = 63978,
    ModelInner = new UInt16UInt160MI
{
    Id = 10,
    Value = 15616,
    NullableValue = 29966,
},
    NullableValue = 50440,
},
            new UInt16UInt160M
{
    Id = 15,
    Value = 20111,
    ModelInner = new UInt16UInt160MI
{
    Id = 14,
    Value = 34922,
    NullableValue = null,
},
    NullableValue = 37059,
},
            new UInt16UInt160M
{
    Id = 21,
    Value = 24987,
    ModelInner = new UInt16UInt160MI
{
    Id = 23,
    Value = 47214,
    NullableValue = 43928,
},
    NullableValue = 54332,
},
            new UInt16UInt160M
{
    Id = 24,
    Value = 36747,
    ModelInner = new UInt16UInt160MI
{
    Id = 31,
    Value = 57988,
    NullableValue = 64926,
},
    NullableValue = 34558,
},
            new UInt16UInt160M
{
    Id = 27,
    Value = 54911,
    ModelInner = new UInt16UInt160MI
{
    Id = 36,
    Value = 22155,
    NullableValue = null,
},
    NullableValue = 52952,
},
            new UInt16UInt160M
{
    Id = 31,
    Value = 39502,
    ModelInner = new UInt16UInt160MI
{
    Id = 45,
    Value = 51095,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 39,
    Value = 30597,
    ModelInner = new UInt16UInt160MI
{
    Id = 48,
    Value = 42746,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 45,
    Value = 63806,
    ModelInner = new UInt16UInt160MI
{
    Id = 57,
    Value = 24133,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 52,
    Value = 49433,
    ModelInner = new UInt16UInt160MI
{
    Id = 62,
    Value = 23072,
    NullableValue = null,
},
    NullableValue = 13404,
},
            new UInt16UInt160M
{
    Id = 60,
    Value = 18947,
    ModelInner = new UInt16UInt160MI
{
    Id = 66,
    Value = 38152,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 68,
    Value = 31238,
    ModelInner = new UInt16UInt160MI
{
    Id = 74,
    Value = 54504,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 69,
    Value = 20338,
    ModelInner = new UInt16UInt160MI
{
    Id = 83,
    Value = 37909,
    NullableValue = 57274,
},
    NullableValue = 41854,
},
            new UInt16UInt160M
{
    Id = 74,
    Value = 46495,
    ModelInner = new UInt16UInt160MI
{
    Id = 89,
    Value = 25981,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 83,
    Value = 25997,
    ModelInner = new UInt16UInt160MI
{
    Id = 98,
    Value = 12871,
    NullableValue = null,
},
    NullableValue = 31944,
},
            new UInt16UInt160M
{
    Id = 87,
    Value = 47486,
    ModelInner = new UInt16UInt160MI
{
    Id = 104,
    Value = 5306,
    NullableValue = null,
},
    NullableValue = 56362,
},
            new UInt16UInt160M
{
    Id = 96,
    Value = 54849,
    ModelInner = new UInt16UInt160MI
{
    Id = 105,
    Value = 49198,
    NullableValue = 349,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 98,
    Value = 25759,
    ModelInner = new UInt16UInt160MI
{
    Id = 107,
    Value = 34957,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 105,
    Value = 53741,
    ModelInner = new UInt16UInt160MI
{
    Id = 108,
    Value = 58698,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 113,
    Value = 39642,
    ModelInner = new UInt16UInt160MI
{
    Id = 115,
    Value = 46591,
    NullableValue = 29718,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 114,
    Value = 55159,
    ModelInner = new UInt16UInt160MI
{
    Id = 116,
    Value = 64840,
    NullableValue = 63370,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 116,
    Value = 56529,
    ModelInner = new UInt16UInt160MI
{
    Id = 121,
    Value = 13017,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 124,
    Value = 10093,
    ModelInner = new UInt16UInt160MI
{
    Id = 122,
    Value = 19708,
    NullableValue = 40858,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 133,
    Value = 25995,
    ModelInner = new UInt16UInt160MI
{
    Id = 128,
    Value = 31839,
    NullableValue = 563,
},
    NullableValue = 50160,
},
            new UInt16UInt160M
{
    Id = 137,
    Value = 28016,
    ModelInner = new UInt16UInt160MI
{
    Id = 134,
    Value = 61081,
    NullableValue = null,
},
    NullableValue = 54922,
},
            new UInt16UInt160M
{
    Id = 141,
    Value = 13348,
    ModelInner = new UInt16UInt160MI
{
    Id = 135,
    Value = 27007,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 149,
    Value = 37773,
    ModelInner = new UInt16UInt160MI
{
    Id = 140,
    Value = 36002,
    NullableValue = null,
},
    NullableValue = 26687,
},
            new UInt16UInt160M
{
    Id = 152,
    Value = 53125,
    ModelInner = new UInt16UInt160MI
{
    Id = 146,
    Value = 44240,
    NullableValue = 8292,
},
    NullableValue = 49300,
},
            new UInt16UInt160M
{
    Id = 159,
    Value = 35727,
    ModelInner = new UInt16UInt160MI
{
    Id = 155,
    Value = 10932,
    NullableValue = 10527,
},
    NullableValue = 25794,
},
            new UInt16UInt160M
{
    Id = 164,
    Value = 23581,
    ModelInner = new UInt16UInt160MI
{
    Id = 160,
    Value = 1255,
    NullableValue = null,
},
    NullableValue = 20936,
},
            new UInt16UInt160M
{
    Id = 172,
    Value = 11803,
    ModelInner = new UInt16UInt160MI
{
    Id = 164,
    Value = 18484,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 179,
    Value = 25485,
    ModelInner = new UInt16UInt160MI
{
    Id = 166,
    Value = 58509,
    NullableValue = null,
},
    NullableValue = 13203,
},
            new UInt16UInt160M
{
    Id = 184,
    Value = 18075,
    ModelInner = new UInt16UInt160MI
{
    Id = 167,
    Value = 10275,
    NullableValue = 3701,
},
    NullableValue = 14209,
},
            new UInt16UInt160M
{
    Id = 190,
    Value = 10923,
    ModelInner = new UInt16UInt160MI
{
    Id = 173,
    Value = 63664,
    NullableValue = 505,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 196,
    Value = 44250,
    ModelInner = new UInt16UInt160MI
{
    Id = 180,
    Value = 9148,
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
INSERT INTO gedaqtests.uint16uint160m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt16}, 
    {mi_id:Int32},
    {mi_value:UInt16}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypeUInt16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16), 
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
                    await ((IUInt16SingleTypeUInt16)this).InsertModelDbConnectionAsync(
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
                     ((IUInt16SingleTypeUInt16)this).InsertModelDbConnection(
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
FROM gedaqtests.uint16uint160m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt16UInt160M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypeUInt16)),
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
                    var models = await ((IUInt16SingleTypeUInt16)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16UInt160M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt16SingleTypeUInt16)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16UInt160M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

