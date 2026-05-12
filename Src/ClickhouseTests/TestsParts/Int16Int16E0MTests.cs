

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
    Id = 5,
    Value = 15182,
    ModelInner = new Int16Int16E0MI
{
    Id = 9,
    Value = 25654,
    NullableValue = 13321,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 12,
    Value = 11827,
    ModelInner = new Int16Int16E0MI
{
    Id = 10,
    Value = 17467,
    NullableValue = 23175,
},
    NullableValue = 13986,
},
            new Int16Int16E0M
{
    Id = 17,
    Value = 15104,
    ModelInner = new Int16Int16E0MI
{
    Id = 11,
    Value = 7681,
    NullableValue = null,
},
    NullableValue = 15348,
},
            new Int16Int16E0M
{
    Id = 22,
    Value = 16926,
    ModelInner = new Int16Int16E0MI
{
    Id = 18,
    Value = 5671,
    NullableValue = 7198,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 31,
    Value = 8800,
    ModelInner = new Int16Int16E0MI
{
    Id = 19,
    Value = 3367,
    NullableValue = null,
},
    NullableValue = 31726,
},
            new Int16Int16E0M
{
    Id = 40,
    Value = 8522,
    ModelInner = new Int16Int16E0MI
{
    Id = 24,
    Value = 3499,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 42,
    Value = 10829,
    ModelInner = new Int16Int16E0MI
{
    Id = 30,
    Value = 413,
    NullableValue = 3689,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 47,
    Value = 1882,
    ModelInner = new Int16Int16E0MI
{
    Id = 35,
    Value = 11797,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 55,
    Value = 13297,
    ModelInner = new Int16Int16E0MI
{
    Id = 38,
    Value = 13960,
    NullableValue = 10780,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 57,
    Value = 8954,
    ModelInner = new Int16Int16E0MI
{
    Id = 43,
    Value = 4322,
    NullableValue = 6344,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 60,
    Value = 16310,
    ModelInner = new Int16Int16E0MI
{
    Id = 46,
    Value = 8087,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 65,
    Value = 31288,
    ModelInner = new Int16Int16E0MI
{
    Id = 48,
    Value = 12227,
    NullableValue = 3745,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 66,
    Value = 21924,
    ModelInner = new Int16Int16E0MI
{
    Id = 54,
    Value = 29925,
    NullableValue = null,
},
    NullableValue = 23849,
},
            new Int16Int16E0M
{
    Id = 73,
    Value = 23224,
    ModelInner = new Int16Int16E0MI
{
    Id = 58,
    Value = 30980,
    NullableValue = 32479,
},
    NullableValue = 14769,
},
            new Int16Int16E0M
{
    Id = 82,
    Value = 28608,
    ModelInner = new Int16Int16E0MI
{
    Id = 64,
    Value = 14662,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 87,
    Value = 16814,
    ModelInner = new Int16Int16E0MI
{
    Id = 72,
    Value = 29193,
    NullableValue = 2288,
},
    NullableValue = 32450,
},
            new Int16Int16E0M
{
    Id = 95,
    Value = 19232,
    ModelInner = new Int16Int16E0MI
{
    Id = 77,
    Value = 27010,
    NullableValue = 17336,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 100,
    Value = 27039,
    ModelInner = new Int16Int16E0MI
{
    Id = 83,
    Value = 17267,
    NullableValue = null,
},
    NullableValue = 2658,
},
            new Int16Int16E0M
{
    Id = 104,
    Value = 27050,
    ModelInner = new Int16Int16E0MI
{
    Id = 91,
    Value = 24610,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 113,
    Value = 5803,
    ModelInner = new Int16Int16E0MI
{
    Id = 95,
    Value = 23511,
    NullableValue = null,
},
    NullableValue = 30124,
},
            new Int16Int16E0M
{
    Id = 116,
    Value = 25179,
    ModelInner = new Int16Int16E0MI
{
    Id = 98,
    Value = 24728,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 120,
    Value = 817,
    ModelInner = new Int16Int16E0MI
{
    Id = 105,
    Value = 24075,
    NullableValue = 5491,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 121,
    Value = 24804,
    ModelInner = new Int16Int16E0MI
{
    Id = 114,
    Value = 2908,
    NullableValue = 11245,
},
    NullableValue = 27958,
},
            new Int16Int16E0M
{
    Id = 127,
    Value = 31375,
    ModelInner = new Int16Int16E0MI
{
    Id = 115,
    Value = 15409,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 132,
    Value = 4257,
    ModelInner = new Int16Int16E0MI
{
    Id = 118,
    Value = 13825,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 135,
    Value = 7534,
    ModelInner = new Int16Int16E0MI
{
    Id = 124,
    Value = 32081,
    NullableValue = 1926,
},
    NullableValue = 10658,
},
            new Int16Int16E0M
{
    Id = 139,
    Value = 15197,
    ModelInner = new Int16Int16E0MI
{
    Id = 130,
    Value = 4405,
    NullableValue = 1708,
},
    NullableValue = 17980,
},
            new Int16Int16E0M
{
    Id = 144,
    Value = 30997,
    ModelInner = new Int16Int16E0MI
{
    Id = 134,
    Value = 18472,
    NullableValue = null,
},
    NullableValue = 9095,
},
            new Int16Int16E0M
{
    Id = 150,
    Value = 6781,
    ModelInner = new Int16Int16E0MI
{
    Id = 136,
    Value = 12275,
    NullableValue = 1309,
},
    NullableValue = 5226,
},
            new Int16Int16E0M
{
    Id = 153,
    Value = 5356,
    ModelInner = new Int16Int16E0MI
{
    Id = 145,
    Value = 9159,
    NullableValue = 6940,
},
    NullableValue = 7454,
},
            new Int16Int16E0M
{
    Id = 156,
    Value = 14804,
    ModelInner = new Int16Int16E0MI
{
    Id = 147,
    Value = 15224,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 159,
    Value = 716,
    ModelInner = new Int16Int16E0MI
{
    Id = 151,
    Value = 6422,
    NullableValue = 283,
},
    NullableValue = 19827,
},
            new Int16Int16E0M
{
    Id = 162,
    Value = 9099,
    ModelInner = new Int16Int16E0MI
{
    Id = 157,
    Value = 23898,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 167,
    Value = 29350,
    ModelInner = new Int16Int16E0MI
{
    Id = 159,
    Value = 7326,
    NullableValue = 20501,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 168,
    Value = 30150,
    ModelInner = new Int16Int16E0MI
{
    Id = 161,
    Value = 7541,
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

