

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
    Id = 9,
    Value = 29892,
    ModelInner = new Int16Int16E0MI
{
    Id = 1,
    Value = 8209,
    NullableValue = 13838,
},
    NullableValue = 10481,
},
            new Int16Int16E0M
{
    Id = 15,
    Value = 19421,
    ModelInner = new Int16Int16E0MI
{
    Id = 7,
    Value = 23690,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 22,
    Value = 20250,
    ModelInner = new Int16Int16E0MI
{
    Id = 12,
    Value = 7296,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 27,
    Value = 11532,
    ModelInner = new Int16Int16E0MI
{
    Id = 20,
    Value = 16697,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 36,
    Value = 28677,
    ModelInner = new Int16Int16E0MI
{
    Id = 24,
    Value = 13698,
    NullableValue = 9277,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 44,
    Value = 9876,
    ModelInner = new Int16Int16E0MI
{
    Id = 33,
    Value = 10640,
    NullableValue = 16161,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 53,
    Value = 11512,
    ModelInner = new Int16Int16E0MI
{
    Id = 41,
    Value = 5785,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 58,
    Value = 2517,
    ModelInner = new Int16Int16E0MI
{
    Id = 46,
    Value = 27529,
    NullableValue = 28132,
},
    NullableValue = 27129,
},
            new Int16Int16E0M
{
    Id = 65,
    Value = 1612,
    ModelInner = new Int16Int16E0MI
{
    Id = 49,
    Value = 27288,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 69,
    Value = 1331,
    ModelInner = new Int16Int16E0MI
{
    Id = 57,
    Value = 9805,
    NullableValue = null,
},
    NullableValue = 24109,
},
            new Int16Int16E0M
{
    Id = 73,
    Value = 25993,
    ModelInner = new Int16Int16E0MI
{
    Id = 59,
    Value = 29130,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 75,
    Value = 3618,
    ModelInner = new Int16Int16E0MI
{
    Id = 61,
    Value = 29978,
    NullableValue = 31867,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 77,
    Value = 18762,
    ModelInner = new Int16Int16E0MI
{
    Id = 68,
    Value = 6404,
    NullableValue = 27310,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 82,
    Value = 27338,
    ModelInner = new Int16Int16E0MI
{
    Id = 72,
    Value = 24992,
    NullableValue = 8615,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 83,
    Value = 29910,
    ModelInner = new Int16Int16E0MI
{
    Id = 76,
    Value = 15125,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 84,
    Value = 31639,
    ModelInner = new Int16Int16E0MI
{
    Id = 82,
    Value = 7237,
    NullableValue = null,
},
    NullableValue = 20242,
},
            new Int16Int16E0M
{
    Id = 87,
    Value = 13201,
    ModelInner = new Int16Int16E0MI
{
    Id = 91,
    Value = 14269,
    NullableValue = 30023,
},
    NullableValue = 1861,
},
            new Int16Int16E0M
{
    Id = 90,
    Value = 4741,
    ModelInner = new Int16Int16E0MI
{
    Id = 96,
    Value = 25577,
    NullableValue = 20041,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 95,
    Value = 31502,
    ModelInner = new Int16Int16E0MI
{
    Id = 105,
    Value = 3872,
    NullableValue = 3453,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 103,
    Value = 6985,
    ModelInner = new Int16Int16E0MI
{
    Id = 111,
    Value = 11127,
    NullableValue = null,
},
    NullableValue = 14833,
},
            new Int16Int16E0M
{
    Id = 104,
    Value = 32728,
    ModelInner = new Int16Int16E0MI
{
    Id = 113,
    Value = 21726,
    NullableValue = null,
},
    NullableValue = 7649,
},
            new Int16Int16E0M
{
    Id = 107,
    Value = 17588,
    ModelInner = new Int16Int16E0MI
{
    Id = 121,
    Value = 32346,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 116,
    Value = 10278,
    ModelInner = new Int16Int16E0MI
{
    Id = 125,
    Value = 27298,
    NullableValue = null,
},
    NullableValue = 20696,
},
            new Int16Int16E0M
{
    Id = 124,
    Value = 3903,
    ModelInner = new Int16Int16E0MI
{
    Id = 126,
    Value = 3304,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 125,
    Value = 28755,
    ModelInner = new Int16Int16E0MI
{
    Id = 131,
    Value = 27729,
    NullableValue = null,
},
    NullableValue = 26645,
},
            new Int16Int16E0M
{
    Id = 126,
    Value = 16476,
    ModelInner = new Int16Int16E0MI
{
    Id = 132,
    Value = 23320,
    NullableValue = null,
},
    NullableValue = 27393,
},
            new Int16Int16E0M
{
    Id = 128,
    Value = 18979,
    ModelInner = new Int16Int16E0MI
{
    Id = 140,
    Value = 24494,
    NullableValue = null,
},
    NullableValue = 32063,
},
            new Int16Int16E0M
{
    Id = 129,
    Value = 7065,
    ModelInner = new Int16Int16E0MI
{
    Id = 149,
    Value = 15511,
    NullableValue = 10136,
},
    NullableValue = 23747,
},
            new Int16Int16E0M
{
    Id = 130,
    Value = 13176,
    ModelInner = new Int16Int16E0MI
{
    Id = 151,
    Value = 31985,
    NullableValue = null,
},
    NullableValue = 6978,
},
            new Int16Int16E0M
{
    Id = 137,
    Value = 23573,
    ModelInner = new Int16Int16E0MI
{
    Id = 155,
    Value = 14719,
    NullableValue = 15731,
},
    NullableValue = 10715,
},
            new Int16Int16E0M
{
    Id = 142,
    Value = 16525,
    ModelInner = new Int16Int16E0MI
{
    Id = 163,
    Value = 21303,
    NullableValue = 6559,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 149,
    Value = 8804,
    ModelInner = new Int16Int16E0MI
{
    Id = 164,
    Value = 22581,
    NullableValue = 16846,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 156,
    Value = 3207,
    ModelInner = new Int16Int16E0MI
{
    Id = 170,
    Value = 3546,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 164,
    Value = 18977,
    ModelInner = new Int16Int16E0MI
{
    Id = 179,
    Value = 32457,
    NullableValue = null,
},
    NullableValue = 23805,
},
            new Int16Int16E0M
{
    Id = 167,
    Value = 21997,
    ModelInner = new Int16Int16E0MI
{
    Id = 188,
    Value = 10694,
    NullableValue = null,
},
    NullableValue = 7396,
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

