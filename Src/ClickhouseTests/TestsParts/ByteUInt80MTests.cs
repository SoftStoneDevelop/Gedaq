

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

        private readonly ByteUInt80M[] _testData = new ByteUInt80M[]
        {
            new ByteUInt80M
{
    Id = 3,
    Value = 114,
    ModelInner = new ByteUInt80MI
{
    Id = 5,
    Value = 159,
    NullableValue = 50,
},
    NullableValue = 32,
},
            new ByteUInt80M
{
    Id = 10,
    Value = 82,
    ModelInner = new ByteUInt80MI
{
    Id = 12,
    Value = 243,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 16,
    Value = 34,
    ModelInner = new ByteUInt80MI
{
    Id = 20,
    Value = 185,
    NullableValue = null,
},
    NullableValue = 215,
},
            new ByteUInt80M
{
    Id = 22,
    Value = 220,
    ModelInner = new ByteUInt80MI
{
    Id = 23,
    Value = 30,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 28,
    Value = 164,
    ModelInner = new ByteUInt80MI
{
    Id = 29,
    Value = 45,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 32,
    Value = 141,
    ModelInner = new ByteUInt80MI
{
    Id = 33,
    Value = 28,
    NullableValue = 216,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 41,
    Value = 15,
    ModelInner = new ByteUInt80MI
{
    Id = 39,
    Value = 51,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 48,
    Value = 4,
    ModelInner = new ByteUInt80MI
{
    Id = 41,
    Value = 14,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 57,
    Value = 194,
    ModelInner = new ByteUInt80MI
{
    Id = 42,
    Value = 172,
    NullableValue = 120,
},
    NullableValue = 115,
},
            new ByteUInt80M
{
    Id = 58,
    Value = 144,
    ModelInner = new ByteUInt80MI
{
    Id = 49,
    Value = 164,
    NullableValue = 28,
},
    NullableValue = 60,
},
            new ByteUInt80M
{
    Id = 64,
    Value = 137,
    ModelInner = new ByteUInt80MI
{
    Id = 52,
    Value = 223,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 66,
    Value = 71,
    ModelInner = new ByteUInt80MI
{
    Id = 53,
    Value = 187,
    NullableValue = 122,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 68,
    Value = 68,
    ModelInner = new ByteUInt80MI
{
    Id = 58,
    Value = 149,
    NullableValue = 195,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 73,
    Value = 217,
    ModelInner = new ByteUInt80MI
{
    Id = 67,
    Value = 35,
    NullableValue = 131,
},
    NullableValue = 55,
},
            new ByteUInt80M
{
    Id = 75,
    Value = 181,
    ModelInner = new ByteUInt80MI
{
    Id = 68,
    Value = 175,
    NullableValue = 190,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 84,
    Value = 169,
    ModelInner = new ByteUInt80MI
{
    Id = 73,
    Value = 17,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 85,
    Value = 104,
    ModelInner = new ByteUInt80MI
{
    Id = 80,
    Value = 171,
    NullableValue = 181,
},
    NullableValue = 135,
},
            new ByteUInt80M
{
    Id = 86,
    Value = 38,
    ModelInner = new ByteUInt80MI
{
    Id = 82,
    Value = 129,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 90,
    Value = 11,
    ModelInner = new ByteUInt80MI
{
    Id = 91,
    Value = 134,
    NullableValue = 122,
},
    NullableValue = 72,
},
            new ByteUInt80M
{
    Id = 95,
    Value = 180,
    ModelInner = new ByteUInt80MI
{
    Id = 98,
    Value = 227,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 101,
    Value = 125,
    ModelInner = new ByteUInt80MI
{
    Id = 106,
    Value = 138,
    NullableValue = 37,
},
    NullableValue = 140,
},
            new ByteUInt80M
{
    Id = 110,
    Value = 94,
    ModelInner = new ByteUInt80MI
{
    Id = 113,
    Value = 11,
    NullableValue = 156,
},
    NullableValue = 175,
},
            new ByteUInt80M
{
    Id = 112,
    Value = 34,
    ModelInner = new ByteUInt80MI
{
    Id = 119,
    Value = 37,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 120,
    Value = 248,
    ModelInner = new ByteUInt80MI
{
    Id = 127,
    Value = 235,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 124,
    Value = 252,
    ModelInner = new ByteUInt80MI
{
    Id = 135,
    Value = 140,
    NullableValue = 26,
},
    NullableValue = 153,
},
            new ByteUInt80M
{
    Id = 133,
    Value = 247,
    ModelInner = new ByteUInt80MI
{
    Id = 137,
    Value = 166,
    NullableValue = 108,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 139,
    Value = 153,
    ModelInner = new ByteUInt80MI
{
    Id = 145,
    Value = 164,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 145,
    Value = 177,
    ModelInner = new ByteUInt80MI
{
    Id = 150,
    Value = 187,
    NullableValue = null,
},
    NullableValue = 157,
},
            new ByteUInt80M
{
    Id = 148,
    Value = 30,
    ModelInner = new ByteUInt80MI
{
    Id = 152,
    Value = 143,
    NullableValue = null,
},
    NullableValue = 52,
},
            new ByteUInt80M
{
    Id = 157,
    Value = 221,
    ModelInner = new ByteUInt80MI
{
    Id = 161,
    Value = 19,
    NullableValue = 164,
},
    NullableValue = 63,
},
            new ByteUInt80M
{
    Id = 166,
    Value = 181,
    ModelInner = new ByteUInt80MI
{
    Id = 162,
    Value = 112,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 169,
    Value = 226,
    ModelInner = new ByteUInt80MI
{
    Id = 168,
    Value = 249,
    NullableValue = null,
},
    NullableValue = 164,
},
            new ByteUInt80M
{
    Id = 177,
    Value = 160,
    ModelInner = new ByteUInt80MI
{
    Id = 177,
    Value = 8,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 186,
    Value = 239,
    ModelInner = new ByteUInt80MI
{
    Id = 185,
    Value = 20,
    NullableValue = null,
},
    NullableValue = 161,
},
            new ByteUInt80M
{
    Id = 188,
    Value = 214,
    ModelInner = new ByteUInt80MI
{
    Id = 190,
    Value = 165,
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
INSERT INTO gedaqtests.byteuint80m(
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
FROM gedaqtests.byteuint80m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(ByteUInt80M)],
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
                    ByteUInt80M.AssertModel(models[0],_testData[i], false);
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
                    ByteUInt80M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

