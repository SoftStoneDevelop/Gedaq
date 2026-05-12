

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
    Id = 7,
    Value = 172,
    ModelInner = new ByteUInt8E0MI
{
    Id = 7,
    Value = 187,
    NullableValue = 21,
},
    NullableValue = 200,
},
            new ByteUInt8E0M
{
    Id = 16,
    Value = 238,
    ModelInner = new ByteUInt8E0MI
{
    Id = 12,
    Value = 143,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 24,
    Value = 80,
    ModelInner = new ByteUInt8E0MI
{
    Id = 21,
    Value = 167,
    NullableValue = 114,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 28,
    Value = 48,
    ModelInner = new ByteUInt8E0MI
{
    Id = 26,
    Value = 188,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 32,
    Value = 59,
    ModelInner = new ByteUInt8E0MI
{
    Id = 35,
    Value = 34,
    NullableValue = null,
},
    NullableValue = 17,
},
            new ByteUInt8E0M
{
    Id = 37,
    Value = 91,
    ModelInner = new ByteUInt8E0MI
{
    Id = 41,
    Value = 180,
    NullableValue = null,
},
    NullableValue = 2,
},
            new ByteUInt8E0M
{
    Id = 38,
    Value = 134,
    ModelInner = new ByteUInt8E0MI
{
    Id = 45,
    Value = 50,
    NullableValue = 111,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 45,
    Value = 61,
    ModelInner = new ByteUInt8E0MI
{
    Id = 46,
    Value = 189,
    NullableValue = null,
},
    NullableValue = 97,
},
            new ByteUInt8E0M
{
    Id = 54,
    Value = 204,
    ModelInner = new ByteUInt8E0MI
{
    Id = 49,
    Value = 12,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 62,
    Value = 175,
    ModelInner = new ByteUInt8E0MI
{
    Id = 53,
    Value = 251,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 71,
    Value = 231,
    ModelInner = new ByteUInt8E0MI
{
    Id = 59,
    Value = 9,
    NullableValue = 66,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 73,
    Value = 57,
    ModelInner = new ByteUInt8E0MI
{
    Id = 65,
    Value = 51,
    NullableValue = 140,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 77,
    Value = 104,
    ModelInner = new ByteUInt8E0MI
{
    Id = 69,
    Value = 69,
    NullableValue = 45,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 82,
    Value = 30,
    ModelInner = new ByteUInt8E0MI
{
    Id = 72,
    Value = 235,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 85,
    Value = 165,
    ModelInner = new ByteUInt8E0MI
{
    Id = 75,
    Value = 182,
    NullableValue = null,
},
    NullableValue = 63,
},
            new ByteUInt8E0M
{
    Id = 88,
    Value = 79,
    ModelInner = new ByteUInt8E0MI
{
    Id = 83,
    Value = 9,
    NullableValue = 111,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 91,
    Value = 206,
    ModelInner = new ByteUInt8E0MI
{
    Id = 85,
    Value = 205,
    NullableValue = 49,
},
    NullableValue = 120,
},
            new ByteUInt8E0M
{
    Id = 99,
    Value = 189,
    ModelInner = new ByteUInt8E0MI
{
    Id = 94,
    Value = 96,
    NullableValue = 27,
},
    NullableValue = 167,
},
            new ByteUInt8E0M
{
    Id = 106,
    Value = 157,
    ModelInner = new ByteUInt8E0MI
{
    Id = 100,
    Value = 144,
    NullableValue = 121,
},
    NullableValue = 89,
},
            new ByteUInt8E0M
{
    Id = 113,
    Value = 144,
    ModelInner = new ByteUInt8E0MI
{
    Id = 107,
    Value = 119,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 120,
    Value = 39,
    ModelInner = new ByteUInt8E0MI
{
    Id = 113,
    Value = 80,
    NullableValue = 230,
},
    NullableValue = 200,
},
            new ByteUInt8E0M
{
    Id = 121,
    Value = 185,
    ModelInner = new ByteUInt8E0MI
{
    Id = 114,
    Value = 112,
    NullableValue = 154,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 129,
    Value = 149,
    ModelInner = new ByteUInt8E0MI
{
    Id = 122,
    Value = 254,
    NullableValue = 16,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 137,
    Value = 168,
    ModelInner = new ByteUInt8E0MI
{
    Id = 131,
    Value = 113,
    NullableValue = 88,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 140,
    Value = 109,
    ModelInner = new ByteUInt8E0MI
{
    Id = 136,
    Value = 222,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 147,
    Value = 195,
    ModelInner = new ByteUInt8E0MI
{
    Id = 145,
    Value = 41,
    NullableValue = null,
},
    NullableValue = 22,
},
            new ByteUInt8E0M
{
    Id = 155,
    Value = 75,
    ModelInner = new ByteUInt8E0MI
{
    Id = 150,
    Value = 251,
    NullableValue = null,
},
    NullableValue = 96,
},
            new ByteUInt8E0M
{
    Id = 157,
    Value = 135,
    ModelInner = new ByteUInt8E0MI
{
    Id = 153,
    Value = 240,
    NullableValue = 58,
},
    NullableValue = 154,
},
            new ByteUInt8E0M
{
    Id = 164,
    Value = 106,
    ModelInner = new ByteUInt8E0MI
{
    Id = 158,
    Value = 81,
    NullableValue = 9,
},
    NullableValue = 94,
},
            new ByteUInt8E0M
{
    Id = 170,
    Value = 33,
    ModelInner = new ByteUInt8E0MI
{
    Id = 162,
    Value = 231,
    NullableValue = 102,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 172,
    Value = 137,
    ModelInner = new ByteUInt8E0MI
{
    Id = 163,
    Value = 87,
    NullableValue = 7,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 179,
    Value = 180,
    ModelInner = new ByteUInt8E0MI
{
    Id = 167,
    Value = 142,
    NullableValue = 157,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 186,
    Value = 127,
    ModelInner = new ByteUInt8E0MI
{
    Id = 174,
    Value = 128,
    NullableValue = 58,
},
    NullableValue = 8,
},
            new ByteUInt8E0M
{
    Id = 192,
    Value = 204,
    ModelInner = new ByteUInt8E0MI
{
    Id = 181,
    Value = 4,
    NullableValue = 76,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 197,
    Value = 213,
    ModelInner = new ByteUInt8E0MI
{
    Id = 186,
    Value = 192,
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

