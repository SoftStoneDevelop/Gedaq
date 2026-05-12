

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
    Value = 42,
    ModelInner = new SByteInt8E0MI
{
    Id = 4,
    Value = 114,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 17,
    Value = 83,
    ModelInner = new SByteInt8E0MI
{
    Id = 6,
    Value = 89,
    NullableValue = null,
},
    NullableValue = -93,
},
            new SByteInt8E0M
{
    Id = 24,
    Value = 119,
    ModelInner = new SByteInt8E0MI
{
    Id = 14,
    Value = -84,
    NullableValue = null,
},
    NullableValue = -26,
},
            new SByteInt8E0M
{
    Id = 33,
    Value = 7,
    ModelInner = new SByteInt8E0MI
{
    Id = 17,
    Value = -35,
    NullableValue = null,
},
    NullableValue = 13,
},
            new SByteInt8E0M
{
    Id = 40,
    Value = 9,
    ModelInner = new SByteInt8E0MI
{
    Id = 18,
    Value = -8,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 41,
    Value = 72,
    ModelInner = new SByteInt8E0MI
{
    Id = 23,
    Value = -58,
    NullableValue = -25,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 43,
    Value = 51,
    ModelInner = new SByteInt8E0MI
{
    Id = 26,
    Value = 77,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 49,
    Value = 14,
    ModelInner = new SByteInt8E0MI
{
    Id = 33,
    Value = -106,
    NullableValue = null,
},
    NullableValue = 47,
},
            new SByteInt8E0M
{
    Id = 50,
    Value = 72,
    ModelInner = new SByteInt8E0MI
{
    Id = 38,
    Value = -32,
    NullableValue = -115,
},
    NullableValue = 107,
},
            new SByteInt8E0M
{
    Id = 51,
    Value = 2,
    ModelInner = new SByteInt8E0MI
{
    Id = 41,
    Value = 85,
    NullableValue = 39,
},
    NullableValue = 28,
},
            new SByteInt8E0M
{
    Id = 54,
    Value = -59,
    ModelInner = new SByteInt8E0MI
{
    Id = 45,
    Value = -53,
    NullableValue = -67,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 62,
    Value = -5,
    ModelInner = new SByteInt8E0MI
{
    Id = 53,
    Value = -30,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 67,
    Value = 83,
    ModelInner = new SByteInt8E0MI
{
    Id = 57,
    Value = -13,
    NullableValue = 61,
},
    NullableValue = 110,
},
            new SByteInt8E0M
{
    Id = 69,
    Value = -14,
    ModelInner = new SByteInt8E0MI
{
    Id = 64,
    Value = -80,
    NullableValue = -79,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 75,
    Value = 69,
    ModelInner = new SByteInt8E0MI
{
    Id = 69,
    Value = 119,
    NullableValue = -62,
},
    NullableValue = 26,
},
            new SByteInt8E0M
{
    Id = 81,
    Value = 28,
    ModelInner = new SByteInt8E0MI
{
    Id = 70,
    Value = 27,
    NullableValue = null,
},
    NullableValue = 101,
},
            new SByteInt8E0M
{
    Id = 84,
    Value = 119,
    ModelInner = new SByteInt8E0MI
{
    Id = 75,
    Value = 2,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 89,
    Value = -34,
    ModelInner = new SByteInt8E0MI
{
    Id = 79,
    Value = 29,
    NullableValue = -67,
},
    NullableValue = 75,
},
            new SByteInt8E0M
{
    Id = 97,
    Value = -112,
    ModelInner = new SByteInt8E0MI
{
    Id = 88,
    Value = 115,
    NullableValue = 122,
},
    NullableValue = 80,
},
            new SByteInt8E0M
{
    Id = 103,
    Value = -40,
    ModelInner = new SByteInt8E0MI
{
    Id = 94,
    Value = 58,
    NullableValue = -31,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 110,
    Value = -49,
    ModelInner = new SByteInt8E0MI
{
    Id = 95,
    Value = -98,
    NullableValue = -73,
},
    NullableValue = -108,
},
            new SByteInt8E0M
{
    Id = 112,
    Value = 1,
    ModelInner = new SByteInt8E0MI
{
    Id = 98,
    Value = -113,
    NullableValue = 87,
},
    NullableValue = 112,
},
            new SByteInt8E0M
{
    Id = 120,
    Value = -3,
    ModelInner = new SByteInt8E0MI
{
    Id = 104,
    Value = 58,
    NullableValue = 50,
},
    NullableValue = 86,
},
            new SByteInt8E0M
{
    Id = 122,
    Value = 80,
    ModelInner = new SByteInt8E0MI
{
    Id = 109,
    Value = 43,
    NullableValue = -74,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 127,
    Value = -75,
    ModelInner = new SByteInt8E0MI
{
    Id = 110,
    Value = 107,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 136,
    Value = 68,
    ModelInner = new SByteInt8E0MI
{
    Id = 114,
    Value = -81,
    NullableValue = -55,
},
    NullableValue = -37,
},
            new SByteInt8E0M
{
    Id = 142,
    Value = 28,
    ModelInner = new SByteInt8E0MI
{
    Id = 123,
    Value = 61,
    NullableValue = -77,
},
    NullableValue = 113,
},
            new SByteInt8E0M
{
    Id = 151,
    Value = -29,
    ModelInner = new SByteInt8E0MI
{
    Id = 126,
    Value = 99,
    NullableValue = 108,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 156,
    Value = 125,
    ModelInner = new SByteInt8E0MI
{
    Id = 131,
    Value = 24,
    NullableValue = -76,
},
    NullableValue = -18,
},
            new SByteInt8E0M
{
    Id = 159,
    Value = -16,
    ModelInner = new SByteInt8E0MI
{
    Id = 134,
    Value = -86,
    NullableValue = -85,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 168,
    Value = 63,
    ModelInner = new SByteInt8E0MI
{
    Id = 140,
    Value = 78,
    NullableValue = null,
},
    NullableValue = 87,
},
            new SByteInt8E0M
{
    Id = 171,
    Value = 65,
    ModelInner = new SByteInt8E0MI
{
    Id = 142,
    Value = 63,
    NullableValue = -2,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 175,
    Value = 46,
    ModelInner = new SByteInt8E0MI
{
    Id = 148,
    Value = 91,
    NullableValue = null,
},
    NullableValue = -97,
},
            new SByteInt8E0M
{
    Id = 180,
    Value = -46,
    ModelInner = new SByteInt8E0MI
{
    Id = 153,
    Value = 50,
    NullableValue = 57,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 181,
    Value = 15,
    ModelInner = new SByteInt8E0MI
{
    Id = 155,
    Value = 69,
    NullableValue = 5,
},
    NullableValue = -80,
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

