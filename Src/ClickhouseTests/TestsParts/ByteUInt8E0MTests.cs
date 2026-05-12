

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
    Id = 5,
    Value = 195,
    ModelInner = new ByteUInt8E0MI
{
    Id = 1,
    Value = 174,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 6,
    Value = 181,
    ModelInner = new ByteUInt8E0MI
{
    Id = 9,
    Value = 110,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 7,
    Value = 107,
    ModelInner = new ByteUInt8E0MI
{
    Id = 17,
    Value = 17,
    NullableValue = null,
},
    NullableValue = 111,
},
            new ByteUInt8E0M
{
    Id = 15,
    Value = 142,
    ModelInner = new ByteUInt8E0MI
{
    Id = 23,
    Value = 59,
    NullableValue = 242,
},
    NullableValue = 62,
},
            new ByteUInt8E0M
{
    Id = 24,
    Value = 12,
    ModelInner = new ByteUInt8E0MI
{
    Id = 26,
    Value = 163,
    NullableValue = 104,
},
    NullableValue = 16,
},
            new ByteUInt8E0M
{
    Id = 26,
    Value = 174,
    ModelInner = new ByteUInt8E0MI
{
    Id = 28,
    Value = 63,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 33,
    Value = 161,
    ModelInner = new ByteUInt8E0MI
{
    Id = 32,
    Value = 66,
    NullableValue = 94,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 36,
    Value = 107,
    ModelInner = new ByteUInt8E0MI
{
    Id = 37,
    Value = 1,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 42,
    Value = 250,
    ModelInner = new ByteUInt8E0MI
{
    Id = 41,
    Value = 40,
    NullableValue = 89,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 47,
    Value = 47,
    ModelInner = new ByteUInt8E0MI
{
    Id = 44,
    Value = 63,
    NullableValue = 90,
},
    NullableValue = 164,
},
            new ByteUInt8E0M
{
    Id = 53,
    Value = 142,
    ModelInner = new ByteUInt8E0MI
{
    Id = 48,
    Value = 25,
    NullableValue = 53,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 59,
    Value = 69,
    ModelInner = new ByteUInt8E0MI
{
    Id = 54,
    Value = 92,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 60,
    Value = 252,
    ModelInner = new ByteUInt8E0MI
{
    Id = 63,
    Value = 128,
    NullableValue = 17,
},
    NullableValue = 171,
},
            new ByteUInt8E0M
{
    Id = 68,
    Value = 125,
    ModelInner = new ByteUInt8E0MI
{
    Id = 72,
    Value = 171,
    NullableValue = null,
},
    NullableValue = 72,
},
            new ByteUInt8E0M
{
    Id = 75,
    Value = 243,
    ModelInner = new ByteUInt8E0MI
{
    Id = 75,
    Value = 4,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 80,
    Value = 226,
    ModelInner = new ByteUInt8E0MI
{
    Id = 79,
    Value = 15,
    NullableValue = 22,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 81,
    Value = 147,
    ModelInner = new ByteUInt8E0MI
{
    Id = 87,
    Value = 250,
    NullableValue = 225,
},
    NullableValue = 144,
},
            new ByteUInt8E0M
{
    Id = 89,
    Value = 32,
    ModelInner = new ByteUInt8E0MI
{
    Id = 96,
    Value = 219,
    NullableValue = 230,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 97,
    Value = 138,
    ModelInner = new ByteUInt8E0MI
{
    Id = 103,
    Value = 191,
    NullableValue = 168,
},
    NullableValue = 248,
},
            new ByteUInt8E0M
{
    Id = 105,
    Value = 69,
    ModelInner = new ByteUInt8E0MI
{
    Id = 105,
    Value = 203,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 112,
    Value = 114,
    ModelInner = new ByteUInt8E0MI
{
    Id = 112,
    Value = 188,
    NullableValue = 120,
},
    NullableValue = 34,
},
            new ByteUInt8E0M
{
    Id = 118,
    Value = 171,
    ModelInner = new ByteUInt8E0MI
{
    Id = 117,
    Value = 245,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 127,
    Value = 66,
    ModelInner = new ByteUInt8E0MI
{
    Id = 124,
    Value = 194,
    NullableValue = 44,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 133,
    Value = 147,
    ModelInner = new ByteUInt8E0MI
{
    Id = 129,
    Value = 113,
    NullableValue = 95,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 138,
    Value = 136,
    ModelInner = new ByteUInt8E0MI
{
    Id = 131,
    Value = 51,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 141,
    Value = 16,
    ModelInner = new ByteUInt8E0MI
{
    Id = 138,
    Value = 173,
    NullableValue = 81,
},
    NullableValue = 203,
},
            new ByteUInt8E0M
{
    Id = 148,
    Value = 56,
    ModelInner = new ByteUInt8E0MI
{
    Id = 140,
    Value = 98,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 149,
    Value = 220,
    ModelInner = new ByteUInt8E0MI
{
    Id = 148,
    Value = 140,
    NullableValue = 130,
},
    NullableValue = 13,
},
            new ByteUInt8E0M
{
    Id = 153,
    Value = 179,
    ModelInner = new ByteUInt8E0MI
{
    Id = 154,
    Value = 243,
    NullableValue = 75,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 162,
    Value = 125,
    ModelInner = new ByteUInt8E0MI
{
    Id = 156,
    Value = 79,
    NullableValue = null,
},
    NullableValue = 240,
},
            new ByteUInt8E0M
{
    Id = 165,
    Value = 122,
    ModelInner = new ByteUInt8E0MI
{
    Id = 165,
    Value = 156,
    NullableValue = null,
},
    NullableValue = 116,
},
            new ByteUInt8E0M
{
    Id = 170,
    Value = 105,
    ModelInner = new ByteUInt8E0MI
{
    Id = 172,
    Value = 45,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 174,
    Value = 23,
    ModelInner = new ByteUInt8E0MI
{
    Id = 179,
    Value = 135,
    NullableValue = 208,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 181,
    Value = 109,
    ModelInner = new ByteUInt8E0MI
{
    Id = 184,
    Value = 65,
    NullableValue = null,
},
    NullableValue = 152,
},
            new ByteUInt8E0M
{
    Id = 183,
    Value = 236,
    ModelInner = new ByteUInt8E0MI
{
    Id = 186,
    Value = 208,
    NullableValue = null,
},
    NullableValue = 94,
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

