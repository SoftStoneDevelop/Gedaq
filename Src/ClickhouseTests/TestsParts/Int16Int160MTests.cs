

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

        private readonly Int16Int160M[] _testData = new Int16Int160M[]
        {
            new Int16Int160M
{
    Id = 1,
    Value = 12478,
    ModelInner = new Int16Int160MI
{
    Id = 4,
    Value = 6647,
    NullableValue = 13593,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 3,
    Value = 22765,
    ModelInner = new Int16Int160MI
{
    Id = 11,
    Value = 16620,
    NullableValue = null,
},
    NullableValue = 12082,
},
            new Int16Int160M
{
    Id = 11,
    Value = 23267,
    ModelInner = new Int16Int160MI
{
    Id = 16,
    Value = 16551,
    NullableValue = 31035,
},
    NullableValue = 7232,
},
            new Int16Int160M
{
    Id = 16,
    Value = 27344,
    ModelInner = new Int16Int160MI
{
    Id = 25,
    Value = 31268,
    NullableValue = 16158,
},
    NullableValue = 5074,
},
            new Int16Int160M
{
    Id = 17,
    Value = 1325,
    ModelInner = new Int16Int160MI
{
    Id = 33,
    Value = 16749,
    NullableValue = 22794,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 24,
    Value = 3201,
    ModelInner = new Int16Int160MI
{
    Id = 39,
    Value = 10858,
    NullableValue = 7635,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 30,
    Value = 19020,
    ModelInner = new Int16Int160MI
{
    Id = 42,
    Value = 1581,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 37,
    Value = 21728,
    ModelInner = new Int16Int160MI
{
    Id = 51,
    Value = 12143,
    NullableValue = 10360,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 40,
    Value = 23755,
    ModelInner = new Int16Int160MI
{
    Id = 56,
    Value = 21995,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 41,
    Value = 31596,
    ModelInner = new Int16Int160MI
{
    Id = 64,
    Value = 23087,
    NullableValue = null,
},
    NullableValue = 4769,
},
            new Int16Int160M
{
    Id = 47,
    Value = 24190,
    ModelInner = new Int16Int160MI
{
    Id = 69,
    Value = 20424,
    NullableValue = 8776,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 48,
    Value = 28498,
    ModelInner = new Int16Int160MI
{
    Id = 75,
    Value = 31618,
    NullableValue = null,
},
    NullableValue = 32553,
},
            new Int16Int160M
{
    Id = 53,
    Value = 30676,
    ModelInner = new Int16Int160MI
{
    Id = 82,
    Value = 15553,
    NullableValue = 24142,
},
    NullableValue = 13716,
},
            new Int16Int160M
{
    Id = 61,
    Value = 25943,
    ModelInner = new Int16Int160MI
{
    Id = 89,
    Value = 6653,
    NullableValue = null,
},
    NullableValue = 3060,
},
            new Int16Int160M
{
    Id = 62,
    Value = 23966,
    ModelInner = new Int16Int160MI
{
    Id = 91,
    Value = 27537,
    NullableValue = 16089,
},
    NullableValue = 17330,
},
            new Int16Int160M
{
    Id = 65,
    Value = 13507,
    ModelInner = new Int16Int160MI
{
    Id = 94,
    Value = 18873,
    NullableValue = 1129,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 72,
    Value = 32115,
    ModelInner = new Int16Int160MI
{
    Id = 100,
    Value = 16828,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 81,
    Value = 13511,
    ModelInner = new Int16Int160MI
{
    Id = 104,
    Value = 4996,
    NullableValue = 11135,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 85,
    Value = 3057,
    ModelInner = new Int16Int160MI
{
    Id = 110,
    Value = 24252,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 92,
    Value = 2784,
    ModelInner = new Int16Int160MI
{
    Id = 116,
    Value = 9497,
    NullableValue = null,
},
    NullableValue = 23109,
},
            new Int16Int160M
{
    Id = 94,
    Value = 1239,
    ModelInner = new Int16Int160MI
{
    Id = 121,
    Value = 17654,
    NullableValue = 8233,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 95,
    Value = 18364,
    ModelInner = new Int16Int160MI
{
    Id = 127,
    Value = 31296,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 103,
    Value = 2410,
    ModelInner = new Int16Int160MI
{
    Id = 132,
    Value = 23352,
    NullableValue = 23700,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 109,
    Value = 10338,
    ModelInner = new Int16Int160MI
{
    Id = 133,
    Value = 18956,
    NullableValue = null,
},
    NullableValue = 3957,
},
            new Int16Int160M
{
    Id = 112,
    Value = 7974,
    ModelInner = new Int16Int160MI
{
    Id = 140,
    Value = 31156,
    NullableValue = 13761,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 113,
    Value = 6997,
    ModelInner = new Int16Int160MI
{
    Id = 145,
    Value = 6711,
    NullableValue = 2502,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 117,
    Value = 27756,
    ModelInner = new Int16Int160MI
{
    Id = 152,
    Value = 19388,
    NullableValue = null,
},
    NullableValue = 20519,
},
            new Int16Int160M
{
    Id = 119,
    Value = 30147,
    ModelInner = new Int16Int160MI
{
    Id = 160,
    Value = 16258,
    NullableValue = null,
},
    NullableValue = 1363,
},
            new Int16Int160M
{
    Id = 125,
    Value = 5982,
    ModelInner = new Int16Int160MI
{
    Id = 162,
    Value = 14051,
    NullableValue = 28550,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 131,
    Value = 6312,
    ModelInner = new Int16Int160MI
{
    Id = 165,
    Value = 23794,
    NullableValue = 12670,
},
    NullableValue = 18817,
},
            new Int16Int160M
{
    Id = 138,
    Value = 30403,
    ModelInner = new Int16Int160MI
{
    Id = 173,
    Value = 8673,
    NullableValue = 7883,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 140,
    Value = 9358,
    ModelInner = new Int16Int160MI
{
    Id = 176,
    Value = 1998,
    NullableValue = 23729,
},
    NullableValue = 3216,
},
            new Int16Int160M
{
    Id = 148,
    Value = 16989,
    ModelInner = new Int16Int160MI
{
    Id = 181,
    Value = 23887,
    NullableValue = 16908,
},
    NullableValue = 22551,
},
            new Int16Int160M
{
    Id = 151,
    Value = 12705,
    ModelInner = new Int16Int160MI
{
    Id = 186,
    Value = 49,
    NullableValue = null,
},
    NullableValue = 11831,
},
            new Int16Int160M
{
    Id = 153,
    Value = 1869,
    ModelInner = new Int16Int160MI
{
    Id = 191,
    Value = 7947,
    NullableValue = null,
},
    NullableValue = 11441,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16int160m(
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
FROM gedaqtests.int16int160m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int16Int160M)],
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
                    Int16Int160M.AssertModel(models[0],_testData[i], false);
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
                    Int16Int160M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

