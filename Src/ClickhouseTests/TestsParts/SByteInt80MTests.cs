

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

        private readonly SByteInt80M[] _testData = new SByteInt80M[]
        {
            new SByteInt80M
{
    Id = 8,
    Value = 94,
    ModelInner = new SByteInt80MI
{
    Id = 8,
    Value = -79,
    NullableValue = 64,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 15,
    Value = -96,
    ModelInner = new SByteInt80MI
{
    Id = 12,
    Value = 71,
    NullableValue = null,
},
    NullableValue = -61,
},
            new SByteInt80M
{
    Id = 18,
    Value = 70,
    ModelInner = new SByteInt80MI
{
    Id = 17,
    Value = 83,
    NullableValue = null,
},
    NullableValue = -80,
},
            new SByteInt80M
{
    Id = 19,
    Value = -88,
    ModelInner = new SByteInt80MI
{
    Id = 19,
    Value = -86,
    NullableValue = 7,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 24,
    Value = 94,
    ModelInner = new SByteInt80MI
{
    Id = 26,
    Value = 63,
    NullableValue = null,
},
    NullableValue = 96,
},
            new SByteInt80M
{
    Id = 31,
    Value = -101,
    ModelInner = new SByteInt80MI
{
    Id = 35,
    Value = -50,
    NullableValue = null,
},
    NullableValue = 0,
},
            new SByteInt80M
{
    Id = 40,
    Value = -10,
    ModelInner = new SByteInt80MI
{
    Id = 36,
    Value = -127,
    NullableValue = -49,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 49,
    Value = -113,
    ModelInner = new SByteInt80MI
{
    Id = 42,
    Value = -4,
    NullableValue = 114,
},
    NullableValue = -57,
},
            new SByteInt80M
{
    Id = 52,
    Value = -127,
    ModelInner = new SByteInt80MI
{
    Id = 49,
    Value = 10,
    NullableValue = -122,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 60,
    Value = 31,
    ModelInner = new SByteInt80MI
{
    Id = 58,
    Value = 100,
    NullableValue = null,
},
    NullableValue = -98,
},
            new SByteInt80M
{
    Id = 66,
    Value = 31,
    ModelInner = new SByteInt80MI
{
    Id = 59,
    Value = 86,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 73,
    Value = -10,
    ModelInner = new SByteInt80MI
{
    Id = 60,
    Value = -127,
    NullableValue = 115,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 82,
    Value = 94,
    ModelInner = new SByteInt80MI
{
    Id = 68,
    Value = -21,
    NullableValue = -17,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 85,
    Value = 43,
    ModelInner = new SByteInt80MI
{
    Id = 69,
    Value = -38,
    NullableValue = -103,
},
    NullableValue = 20,
},
            new SByteInt80M
{
    Id = 86,
    Value = 110,
    ModelInner = new SByteInt80MI
{
    Id = 78,
    Value = 15,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 95,
    Value = -116,
    ModelInner = new SByteInt80MI
{
    Id = 86,
    Value = -32,
    NullableValue = null,
},
    NullableValue = 51,
},
            new SByteInt80M
{
    Id = 96,
    Value = -52,
    ModelInner = new SByteInt80MI
{
    Id = 93,
    Value = -92,
    NullableValue = null,
},
    NullableValue = 85,
},
            new SByteInt80M
{
    Id = 98,
    Value = -128,
    ModelInner = new SByteInt80MI
{
    Id = 96,
    Value = 87,
    NullableValue = -61,
},
    NullableValue = -98,
},
            new SByteInt80M
{
    Id = 104,
    Value = 125,
    ModelInner = new SByteInt80MI
{
    Id = 103,
    Value = -113,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 108,
    Value = 41,
    ModelInner = new SByteInt80MI
{
    Id = 106,
    Value = 22,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 109,
    Value = 100,
    ModelInner = new SByteInt80MI
{
    Id = 108,
    Value = 23,
    NullableValue = -69,
},
    NullableValue = -81,
},
            new SByteInt80M
{
    Id = 118,
    Value = -25,
    ModelInner = new SByteInt80MI
{
    Id = 109,
    Value = -56,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 123,
    Value = -98,
    ModelInner = new SByteInt80MI
{
    Id = 114,
    Value = 63,
    NullableValue = 113,
},
    NullableValue = -70,
},
            new SByteInt80M
{
    Id = 124,
    Value = 1,
    ModelInner = new SByteInt80MI
{
    Id = 116,
    Value = 8,
    NullableValue = -72,
},
    NullableValue = 71,
},
            new SByteInt80M
{
    Id = 131,
    Value = 115,
    ModelInner = new SByteInt80MI
{
    Id = 124,
    Value = -126,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 132,
    Value = -105,
    ModelInner = new SByteInt80MI
{
    Id = 127,
    Value = 93,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 138,
    Value = 72,
    ModelInner = new SByteInt80MI
{
    Id = 131,
    Value = 37,
    NullableValue = null,
},
    NullableValue = -105,
},
            new SByteInt80M
{
    Id = 143,
    Value = 58,
    ModelInner = new SByteInt80MI
{
    Id = 138,
    Value = 87,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 150,
    Value = 33,
    ModelInner = new SByteInt80MI
{
    Id = 143,
    Value = -121,
    NullableValue = null,
},
    NullableValue = 45,
},
            new SByteInt80M
{
    Id = 156,
    Value = -57,
    ModelInner = new SByteInt80MI
{
    Id = 145,
    Value = 79,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 160,
    Value = 90,
    ModelInner = new SByteInt80MI
{
    Id = 154,
    Value = 120,
    NullableValue = null,
},
    NullableValue = 81,
},
            new SByteInt80M
{
    Id = 166,
    Value = -53,
    ModelInner = new SByteInt80MI
{
    Id = 163,
    Value = -28,
    NullableValue = null,
},
    NullableValue = 16,
},
            new SByteInt80M
{
    Id = 169,
    Value = -92,
    ModelInner = new SByteInt80MI
{
    Id = 164,
    Value = 73,
    NullableValue = 79,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 177,
    Value = -15,
    ModelInner = new SByteInt80MI
{
    Id = 166,
    Value = 5,
    NullableValue = 84,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 181,
    Value = -124,
    ModelInner = new SByteInt80MI
{
    Id = 168,
    Value = -118,
    NullableValue = null,
},
    NullableValue = 65,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.sbyteint80m(
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
FROM gedaqtests.sbyteint80m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(SByteInt80M)],
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
                    SByteInt80M.AssertModel(models[0],_testData[i], false);
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
                    SByteInt80M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

