

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
    internal partial interface ISByteSingleTypeInt8
    {
    }
    
    internal partial class SByteSingleTypeInt8 : ISByteSingleTypeInt8
    {


#region TestData

        private readonly SByteInt8E0M[] _testData = new SByteInt8E0M[]
        {
            new SByteInt8E0M
{
    Id = 8,
    Value = 107,
    ModelInner = new SByteInt8E0MI
{
    Id = 9,
    Value = -69,
    NullableValue = 47,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 12,
    Value = -27,
    ModelInner = new SByteInt8E0MI
{
    Id = 13,
    Value = -103,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 21,
    Value = -118,
    ModelInner = new SByteInt8E0MI
{
    Id = 22,
    Value = 101,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 25,
    Value = 88,
    ModelInner = new SByteInt8E0MI
{
    Id = 31,
    Value = 97,
    NullableValue = 67,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 28,
    Value = 7,
    ModelInner = new SByteInt8E0MI
{
    Id = 40,
    Value = -20,
    NullableValue = -56,
},
    NullableValue = 29,
},
            new SByteInt8E0M
{
    Id = 34,
    Value = 96,
    ModelInner = new SByteInt8E0MI
{
    Id = 46,
    Value = -8,
    NullableValue = null,
},
    NullableValue = -79,
},
            new SByteInt8E0M
{
    Id = 38,
    Value = -65,
    ModelInner = new SByteInt8E0MI
{
    Id = 53,
    Value = -16,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 40,
    Value = -121,
    ModelInner = new SByteInt8E0MI
{
    Id = 55,
    Value = -95,
    NullableValue = -7,
},
    NullableValue = -86,
},
            new SByteInt8E0M
{
    Id = 49,
    Value = -65,
    ModelInner = new SByteInt8E0MI
{
    Id = 62,
    Value = -90,
    NullableValue = null,
},
    NullableValue = 75,
},
            new SByteInt8E0M
{
    Id = 54,
    Value = 28,
    ModelInner = new SByteInt8E0MI
{
    Id = 68,
    Value = -118,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 60,
    Value = 45,
    ModelInner = new SByteInt8E0MI
{
    Id = 72,
    Value = -73,
    NullableValue = 108,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 67,
    Value = 112,
    ModelInner = new SByteInt8E0MI
{
    Id = 81,
    Value = 26,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 72,
    Value = 26,
    ModelInner = new SByteInt8E0MI
{
    Id = 90,
    Value = 57,
    NullableValue = -127,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 74,
    Value = -50,
    ModelInner = new SByteInt8E0MI
{
    Id = 93,
    Value = -4,
    NullableValue = -92,
},
    NullableValue = -109,
},
            new SByteInt8E0M
{
    Id = 78,
    Value = -73,
    ModelInner = new SByteInt8E0MI
{
    Id = 102,
    Value = 37,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 85,
    Value = -124,
    ModelInner = new SByteInt8E0MI
{
    Id = 111,
    Value = 108,
    NullableValue = -31,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 89,
    Value = -54,
    ModelInner = new SByteInt8E0MI
{
    Id = 114,
    Value = 56,
    NullableValue = null,
},
    NullableValue = -82,
},
            new SByteInt8E0M
{
    Id = 97,
    Value = -64,
    ModelInner = new SByteInt8E0MI
{
    Id = 123,
    Value = -115,
    NullableValue = null,
},
    NullableValue = -82,
},
            new SByteInt8E0M
{
    Id = 103,
    Value = 44,
    ModelInner = new SByteInt8E0MI
{
    Id = 131,
    Value = -22,
    NullableValue = null,
},
    NullableValue = 52,
},
            new SByteInt8E0M
{
    Id = 110,
    Value = -104,
    ModelInner = new SByteInt8E0MI
{
    Id = 137,
    Value = -107,
    NullableValue = null,
},
    NullableValue = 45,
},
            new SByteInt8E0M
{
    Id = 111,
    Value = -37,
    ModelInner = new SByteInt8E0MI
{
    Id = 143,
    Value = -4,
    NullableValue = null,
},
    NullableValue = -113,
},
            new SByteInt8E0M
{
    Id = 119,
    Value = -8,
    ModelInner = new SByteInt8E0MI
{
    Id = 150,
    Value = -71,
    NullableValue = -92,
},
    NullableValue = -74,
},
            new SByteInt8E0M
{
    Id = 122,
    Value = -122,
    ModelInner = new SByteInt8E0MI
{
    Id = 159,
    Value = 45,
    NullableValue = null,
},
    NullableValue = -12,
},
            new SByteInt8E0M
{
    Id = 126,
    Value = 34,
    ModelInner = new SByteInt8E0MI
{
    Id = 160,
    Value = 23,
    NullableValue = null,
},
    NullableValue = 40,
},
            new SByteInt8E0M
{
    Id = 127,
    Value = 35,
    ModelInner = new SByteInt8E0MI
{
    Id = 161,
    Value = 32,
    NullableValue = 86,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 129,
    Value = -105,
    ModelInner = new SByteInt8E0MI
{
    Id = 169,
    Value = -58,
    NullableValue = 111,
},
    NullableValue = -9,
},
            new SByteInt8E0M
{
    Id = 135,
    Value = 88,
    ModelInner = new SByteInt8E0MI
{
    Id = 176,
    Value = -69,
    NullableValue = 100,
},
    NullableValue = -100,
},
            new SByteInt8E0M
{
    Id = 137,
    Value = -85,
    ModelInner = new SByteInt8E0MI
{
    Id = 177,
    Value = -31,
    NullableValue = null,
},
    NullableValue = -110,
},
            new SByteInt8E0M
{
    Id = 144,
    Value = -100,
    ModelInner = new SByteInt8E0MI
{
    Id = 181,
    Value = -34,
    NullableValue = null,
},
    NullableValue = -65,
},
            new SByteInt8E0M
{
    Id = 153,
    Value = -60,
    ModelInner = new SByteInt8E0MI
{
    Id = 187,
    Value = 75,
    NullableValue = null,
},
    NullableValue = -14,
},
            new SByteInt8E0M
{
    Id = 160,
    Value = 113,
    ModelInner = new SByteInt8E0MI
{
    Id = 194,
    Value = 56,
    NullableValue = null,
},
    NullableValue = -4,
},
            new SByteInt8E0M
{
    Id = 161,
    Value = 93,
    ModelInner = new SByteInt8E0MI
{
    Id = 203,
    Value = -32,
    NullableValue = -31,
},
    NullableValue = -3,
},
            new SByteInt8E0M
{
    Id = 167,
    Value = -91,
    ModelInner = new SByteInt8E0MI
{
    Id = 206,
    Value = 119,
    NullableValue = -35,
},
    NullableValue = -36,
},
            new SByteInt8E0M
{
    Id = 175,
    Value = -105,
    ModelInner = new SByteInt8E0MI
{
    Id = 215,
    Value = -12,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 176,
    Value = -26,
    ModelInner = new SByteInt8E0MI
{
    Id = 222,
    Value = 2,
    NullableValue = 91,
},
    NullableValue = -26,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.sbyteint8e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Int8}, 
    {mi_id:Int32},
    {mi_value:Int8}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypeInt8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte), 
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
                    await ((ISByteSingleTypeInt8)this).InsertModelDbConnectionAsync(
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
                     ((ISByteSingleTypeInt8)this).InsertModelDbConnection(
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
FROM gedaqtests.sbyteint8e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(SByteInt8E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypeInt8)),
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
                    var models = await ((ISByteSingleTypeInt8)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteInt8E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((ISByteSingleTypeInt8)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteInt8E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

