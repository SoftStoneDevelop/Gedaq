

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
    Id = 2,
    Value = -92,
    ModelInner = new SByteInt8E0MI
{
    Id = 8,
    Value = -53,
    NullableValue = -30,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 5,
    Value = 78,
    ModelInner = new SByteInt8E0MI
{
    Id = 16,
    Value = 72,
    NullableValue = -49,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 10,
    Value = 62,
    ModelInner = new SByteInt8E0MI
{
    Id = 24,
    Value = 119,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 16,
    Value = 47,
    ModelInner = new SByteInt8E0MI
{
    Id = 29,
    Value = 0,
    NullableValue = -110,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 22,
    Value = -101,
    ModelInner = new SByteInt8E0MI
{
    Id = 34,
    Value = -6,
    NullableValue = 21,
},
    NullableValue = 6,
},
            new SByteInt8E0M
{
    Id = 25,
    Value = -42,
    ModelInner = new SByteInt8E0MI
{
    Id = 36,
    Value = 123,
    NullableValue = -12,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 32,
    Value = 82,
    ModelInner = new SByteInt8E0MI
{
    Id = 39,
    Value = 71,
    NullableValue = -25,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 40,
    Value = 120,
    ModelInner = new SByteInt8E0MI
{
    Id = 47,
    Value = -22,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 43,
    Value = -86,
    ModelInner = new SByteInt8E0MI
{
    Id = 53,
    Value = -51,
    NullableValue = -118,
},
    NullableValue = -29,
},
            new SByteInt8E0M
{
    Id = 46,
    Value = -92,
    ModelInner = new SByteInt8E0MI
{
    Id = 55,
    Value = -15,
    NullableValue = -41,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 50,
    Value = 95,
    ModelInner = new SByteInt8E0MI
{
    Id = 56,
    Value = -19,
    NullableValue = 116,
},
    NullableValue = -112,
},
            new SByteInt8E0M
{
    Id = 56,
    Value = -114,
    ModelInner = new SByteInt8E0MI
{
    Id = 61,
    Value = 71,
    NullableValue = null,
},
    NullableValue = -110,
},
            new SByteInt8E0M
{
    Id = 65,
    Value = 48,
    ModelInner = new SByteInt8E0MI
{
    Id = 63,
    Value = -23,
    NullableValue = 20,
},
    NullableValue = 61,
},
            new SByteInt8E0M
{
    Id = 69,
    Value = -23,
    ModelInner = new SByteInt8E0MI
{
    Id = 64,
    Value = -125,
    NullableValue = 87,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 70,
    Value = -114,
    ModelInner = new SByteInt8E0MI
{
    Id = 73,
    Value = 121,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 72,
    Value = -11,
    ModelInner = new SByteInt8E0MI
{
    Id = 80,
    Value = 1,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 77,
    Value = 67,
    ModelInner = new SByteInt8E0MI
{
    Id = 82,
    Value = -80,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 81,
    Value = 87,
    ModelInner = new SByteInt8E0MI
{
    Id = 87,
    Value = -45,
    NullableValue = -106,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 86,
    Value = -43,
    ModelInner = new SByteInt8E0MI
{
    Id = 93,
    Value = -33,
    NullableValue = 99,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 89,
    Value = -87,
    ModelInner = new SByteInt8E0MI
{
    Id = 94,
    Value = 51,
    NullableValue = null,
},
    NullableValue = 97,
},
            new SByteInt8E0M
{
    Id = 98,
    Value = 95,
    ModelInner = new SByteInt8E0MI
{
    Id = 103,
    Value = 87,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 104,
    Value = 67,
    ModelInner = new SByteInt8E0MI
{
    Id = 111,
    Value = -42,
    NullableValue = 25,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 111,
    Value = -128,
    ModelInner = new SByteInt8E0MI
{
    Id = 114,
    Value = -11,
    NullableValue = -126,
},
    NullableValue = 76,
},
            new SByteInt8E0M
{
    Id = 116,
    Value = -65,
    ModelInner = new SByteInt8E0MI
{
    Id = 116,
    Value = 98,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 119,
    Value = 86,
    ModelInner = new SByteInt8E0MI
{
    Id = 118,
    Value = -58,
    NullableValue = null,
},
    NullableValue = 48,
},
            new SByteInt8E0M
{
    Id = 121,
    Value = -103,
    ModelInner = new SByteInt8E0MI
{
    Id = 121,
    Value = 106,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 123,
    Value = -30,
    ModelInner = new SByteInt8E0MI
{
    Id = 129,
    Value = 0,
    NullableValue = -124,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 128,
    Value = -93,
    ModelInner = new SByteInt8E0MI
{
    Id = 138,
    Value = 81,
    NullableValue = null,
},
    NullableValue = -103,
},
            new SByteInt8E0M
{
    Id = 135,
    Value = 62,
    ModelInner = new SByteInt8E0MI
{
    Id = 142,
    Value = -117,
    NullableValue = null,
},
    NullableValue = -32,
},
            new SByteInt8E0M
{
    Id = 141,
    Value = 16,
    ModelInner = new SByteInt8E0MI
{
    Id = 143,
    Value = -1,
    NullableValue = -114,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 149,
    Value = 4,
    ModelInner = new SByteInt8E0MI
{
    Id = 147,
    Value = -57,
    NullableValue = -21,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 153,
    Value = 19,
    ModelInner = new SByteInt8E0MI
{
    Id = 153,
    Value = 28,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 155,
    Value = 113,
    ModelInner = new SByteInt8E0MI
{
    Id = 159,
    Value = -5,
    NullableValue = 103,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 156,
    Value = 108,
    ModelInner = new SByteInt8E0MI
{
    Id = 167,
    Value = 81,
    NullableValue = -18,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 160,
    Value = 50,
    ModelInner = new SByteInt8E0MI
{
    Id = 170,
    Value = 69,
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

