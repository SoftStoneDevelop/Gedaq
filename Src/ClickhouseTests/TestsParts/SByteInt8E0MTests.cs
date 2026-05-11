

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
    Value = 83,
    ModelInner = new SByteInt8E0MI
{
    Id = 9,
    Value = -128,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 17,
    Value = 53,
    ModelInner = new SByteInt8E0MI
{
    Id = 11,
    Value = -121,
    NullableValue = -121,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 25,
    Value = 92,
    ModelInner = new SByteInt8E0MI
{
    Id = 16,
    Value = -58,
    NullableValue = -81,
},
    NullableValue = -25,
},
            new SByteInt8E0M
{
    Id = 29,
    Value = -95,
    ModelInner = new SByteInt8E0MI
{
    Id = 23,
    Value = 39,
    NullableValue = -14,
},
    NullableValue = 110,
},
            new SByteInt8E0M
{
    Id = 35,
    Value = -39,
    ModelInner = new SByteInt8E0MI
{
    Id = 27,
    Value = 3,
    NullableValue = null,
},
    NullableValue = 24,
},
            new SByteInt8E0M
{
    Id = 38,
    Value = -78,
    ModelInner = new SByteInt8E0MI
{
    Id = 35,
    Value = -79,
    NullableValue = 108,
},
    NullableValue = 6,
},
            new SByteInt8E0M
{
    Id = 39,
    Value = -75,
    ModelInner = new SByteInt8E0MI
{
    Id = 36,
    Value = 21,
    NullableValue = -73,
},
    NullableValue = 16,
},
            new SByteInt8E0M
{
    Id = 48,
    Value = -46,
    ModelInner = new SByteInt8E0MI
{
    Id = 39,
    Value = 125,
    NullableValue = null,
},
    NullableValue = -73,
},
            new SByteInt8E0M
{
    Id = 55,
    Value = -5,
    ModelInner = new SByteInt8E0MI
{
    Id = 40,
    Value = 125,
    NullableValue = null,
},
    NullableValue = -7,
},
            new SByteInt8E0M
{
    Id = 64,
    Value = 65,
    ModelInner = new SByteInt8E0MI
{
    Id = 43,
    Value = -54,
    NullableValue = -69,
},
    NullableValue = -110,
},
            new SByteInt8E0M
{
    Id = 70,
    Value = -116,
    ModelInner = new SByteInt8E0MI
{
    Id = 52,
    Value = -68,
    NullableValue = null,
},
    NullableValue = 63,
},
            new SByteInt8E0M
{
    Id = 76,
    Value = 20,
    ModelInner = new SByteInt8E0MI
{
    Id = 58,
    Value = 121,
    NullableValue = null,
},
    NullableValue = 116,
},
            new SByteInt8E0M
{
    Id = 79,
    Value = 99,
    ModelInner = new SByteInt8E0MI
{
    Id = 63,
    Value = 77,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 82,
    Value = -54,
    ModelInner = new SByteInt8E0MI
{
    Id = 71,
    Value = 85,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 90,
    Value = -76,
    ModelInner = new SByteInt8E0MI
{
    Id = 73,
    Value = -90,
    NullableValue = 61,
},
    NullableValue = -128,
},
            new SByteInt8E0M
{
    Id = 96,
    Value = -32,
    ModelInner = new SByteInt8E0MI
{
    Id = 75,
    Value = -51,
    NullableValue = -125,
},
    NullableValue = 91,
},
            new SByteInt8E0M
{
    Id = 99,
    Value = 10,
    ModelInner = new SByteInt8E0MI
{
    Id = 79,
    Value = 59,
    NullableValue = null,
},
    NullableValue = -83,
},
            new SByteInt8E0M
{
    Id = 101,
    Value = -92,
    ModelInner = new SByteInt8E0MI
{
    Id = 81,
    Value = -111,
    NullableValue = null,
},
    NullableValue = -48,
},
            new SByteInt8E0M
{
    Id = 103,
    Value = -13,
    ModelInner = new SByteInt8E0MI
{
    Id = 83,
    Value = -117,
    NullableValue = 109,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 108,
    Value = 22,
    ModelInner = new SByteInt8E0MI
{
    Id = 91,
    Value = 46,
    NullableValue = null,
},
    NullableValue = 57,
},
            new SByteInt8E0M
{
    Id = 114,
    Value = -115,
    ModelInner = new SByteInt8E0MI
{
    Id = 98,
    Value = 9,
    NullableValue = 81,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 121,
    Value = 14,
    ModelInner = new SByteInt8E0MI
{
    Id = 104,
    Value = -84,
    NullableValue = null,
},
    NullableValue = -16,
},
            new SByteInt8E0M
{
    Id = 130,
    Value = 62,
    ModelInner = new SByteInt8E0MI
{
    Id = 106,
    Value = 80,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 132,
    Value = -121,
    ModelInner = new SByteInt8E0MI
{
    Id = 110,
    Value = 68,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 134,
    Value = 5,
    ModelInner = new SByteInt8E0MI
{
    Id = 111,
    Value = 56,
    NullableValue = 19,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 136,
    Value = 5,
    ModelInner = new SByteInt8E0MI
{
    Id = 113,
    Value = 125,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 141,
    Value = -81,
    ModelInner = new SByteInt8E0MI
{
    Id = 121,
    Value = 98,
    NullableValue = -81,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 144,
    Value = 91,
    ModelInner = new SByteInt8E0MI
{
    Id = 126,
    Value = 13,
    NullableValue = 13,
},
    NullableValue = -73,
},
            new SByteInt8E0M
{
    Id = 153,
    Value = -38,
    ModelInner = new SByteInt8E0MI
{
    Id = 131,
    Value = 67,
    NullableValue = -24,
},
    NullableValue = 126,
},
            new SByteInt8E0M
{
    Id = 159,
    Value = 35,
    ModelInner = new SByteInt8E0MI
{
    Id = 133,
    Value = 18,
    NullableValue = -101,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 160,
    Value = -81,
    ModelInner = new SByteInt8E0MI
{
    Id = 139,
    Value = -47,
    NullableValue = 62,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 161,
    Value = -26,
    ModelInner = new SByteInt8E0MI
{
    Id = 148,
    Value = 89,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 162,
    Value = 21,
    ModelInner = new SByteInt8E0MI
{
    Id = 157,
    Value = 2,
    NullableValue = -85,
},
    NullableValue = 59,
},
            new SByteInt8E0M
{
    Id = 164,
    Value = -46,
    ModelInner = new SByteInt8E0MI
{
    Id = 164,
    Value = 56,
    NullableValue = -24,
},
    NullableValue = 11,
},
            new SByteInt8E0M
{
    Id = 165,
    Value = 66,
    ModelInner = new SByteInt8E0MI
{
    Id = 166,
    Value = -21,
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

