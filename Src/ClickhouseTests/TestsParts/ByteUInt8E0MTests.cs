

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
    internal partial interface IByteSingleTypeUInt8
    {
    }
    
    internal partial class ByteSingleTypeUInt8 : IByteSingleTypeUInt8
    {


#region TestData

        private readonly ByteUInt8E0M[] _testData = new ByteUInt8E0M[]
        {
            new ByteUInt8E0M
{
    Id = 6,
    Value = 133,
    ModelInner = new ByteUInt80MI
{
    Id = 1,
    Value = 41,
    NullableValue = 86,
},
    NullableValue = 16,
},
            new ByteUInt8E0M
{
    Id = 8,
    Value = 182,
    ModelInner = new ByteUInt80MI
{
    Id = 7,
    Value = 87,
    NullableValue = 82,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 11,
    Value = 243,
    ModelInner = new ByteUInt80MI
{
    Id = 15,
    Value = 110,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 20,
    Value = 28,
    ModelInner = new ByteUInt80MI
{
    Id = 24,
    Value = 132,
    NullableValue = 95,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 25,
    Value = 28,
    ModelInner = new ByteUInt80MI
{
    Id = 32,
    Value = 13,
    NullableValue = null,
},
    NullableValue = 143,
},
            new ByteUInt8E0M
{
    Id = 30,
    Value = 215,
    ModelInner = new ByteUInt80MI
{
    Id = 39,
    Value = 135,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 38,
    Value = 160,
    ModelInner = new ByteUInt80MI
{
    Id = 41,
    Value = 103,
    NullableValue = 146,
},
    NullableValue = 178,
},
            new ByteUInt8E0M
{
    Id = 44,
    Value = 124,
    ModelInner = new ByteUInt80MI
{
    Id = 45,
    Value = 212,
    NullableValue = 87,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 45,
    Value = 156,
    ModelInner = new ByteUInt80MI
{
    Id = 48,
    Value = 140,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 52,
    Value = 135,
    ModelInner = new ByteUInt80MI
{
    Id = 49,
    Value = 223,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 59,
    Value = 186,
    ModelInner = new ByteUInt80MI
{
    Id = 54,
    Value = 226,
    NullableValue = 24,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 68,
    Value = 128,
    ModelInner = new ByteUInt80MI
{
    Id = 60,
    Value = 162,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 71,
    Value = 64,
    ModelInner = new ByteUInt80MI
{
    Id = 62,
    Value = 82,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 74,
    Value = 226,
    ModelInner = new ByteUInt80MI
{
    Id = 68,
    Value = 31,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 82,
    Value = 4,
    ModelInner = new ByteUInt80MI
{
    Id = 72,
    Value = 177,
    NullableValue = 176,
},
    NullableValue = 81,
},
            new ByteUInt8E0M
{
    Id = 83,
    Value = 77,
    ModelInner = new ByteUInt80MI
{
    Id = 78,
    Value = 116,
    NullableValue = null,
},
    NullableValue = 77,
},
            new ByteUInt8E0M
{
    Id = 86,
    Value = 51,
    ModelInner = new ByteUInt80MI
{
    Id = 83,
    Value = 105,
    NullableValue = null,
},
    NullableValue = 148,
},
            new ByteUInt8E0M
{
    Id = 88,
    Value = 118,
    ModelInner = new ByteUInt80MI
{
    Id = 88,
    Value = 167,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 94,
    Value = 23,
    ModelInner = new ByteUInt80MI
{
    Id = 91,
    Value = 2,
    NullableValue = null,
},
    NullableValue = 46,
},
            new ByteUInt8E0M
{
    Id = 102,
    Value = 166,
    ModelInner = new ByteUInt80MI
{
    Id = 98,
    Value = 208,
    NullableValue = 189,
},
    NullableValue = 101,
},
            new ByteUInt8E0M
{
    Id = 104,
    Value = 165,
    ModelInner = new ByteUInt80MI
{
    Id = 106,
    Value = 52,
    NullableValue = 127,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 111,
    Value = 87,
    ModelInner = new ByteUInt80MI
{
    Id = 111,
    Value = 210,
    NullableValue = 74,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 117,
    Value = 113,
    ModelInner = new ByteUInt80MI
{
    Id = 118,
    Value = 30,
    NullableValue = null,
},
    NullableValue = 115,
},
            new ByteUInt8E0M
{
    Id = 120,
    Value = 103,
    ModelInner = new ByteUInt80MI
{
    Id = 126,
    Value = 219,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 123,
    Value = 238,
    ModelInner = new ByteUInt80MI
{
    Id = 133,
    Value = 36,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 124,
    Value = 164,
    ModelInner = new ByteUInt80MI
{
    Id = 140,
    Value = 63,
    NullableValue = 87,
},
    NullableValue = 5,
},
            new ByteUInt8E0M
{
    Id = 132,
    Value = 11,
    ModelInner = new ByteUInt80MI
{
    Id = 148,
    Value = 16,
    NullableValue = null,
},
    NullableValue = 192,
},
            new ByteUInt8E0M
{
    Id = 141,
    Value = 184,
    ModelInner = new ByteUInt80MI
{
    Id = 150,
    Value = 219,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 144,
    Value = 248,
    ModelInner = new ByteUInt80MI
{
    Id = 154,
    Value = 168,
    NullableValue = 234,
},
    NullableValue = 5,
},
            new ByteUInt8E0M
{
    Id = 152,
    Value = 242,
    ModelInner = new ByteUInt80MI
{
    Id = 155,
    Value = 61,
    NullableValue = null,
},
    NullableValue = 132,
},
            new ByteUInt8E0M
{
    Id = 154,
    Value = 51,
    ModelInner = new ByteUInt80MI
{
    Id = 164,
    Value = 110,
    NullableValue = 197,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 161,
    Value = 99,
    ModelInner = new ByteUInt80MI
{
    Id = 172,
    Value = 224,
    NullableValue = null,
},
    NullableValue = 3,
},
            new ByteUInt8E0M
{
    Id = 168,
    Value = 208,
    ModelInner = new ByteUInt80MI
{
    Id = 180,
    Value = 176,
    NullableValue = 38,
},
    NullableValue = 251,
},
            new ByteUInt8E0M
{
    Id = 171,
    Value = 18,
    ModelInner = new ByteUInt80MI
{
    Id = 185,
    Value = 106,
    NullableValue = null,
},
    NullableValue = 227,
},
            new ByteUInt8E0M
{
    Id = 173,
    Value = 248,
    ModelInner = new ByteUInt80MI
{
    Id = 191,
    Value = 57,
    NullableValue = null,
},
    NullableValue = 80,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.byteuint8e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt8}, 
    {mi_id:Int32},
    {mi_value:UInt8}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypeUInt8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte), 
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
                    await ((IByteSingleTypeUInt8)this).InsertModelDbConnectionAsync(
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
                     ((IByteSingleTypeUInt8)this).InsertModelDbConnection(
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
FROM gedaqtests.byteuint8e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(ByteUInt8E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypeUInt8)),
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
                    var models = await ((IByteSingleTypeUInt8)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteUInt8E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IByteSingleTypeUInt8)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteUInt8E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

