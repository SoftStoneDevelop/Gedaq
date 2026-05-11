

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
    Id = 9,
    Value = 89,
    ModelInner = new ByteUInt8E0MI
{
    Id = 4,
    Value = 47,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 12,
    Value = 219,
    ModelInner = new ByteUInt8E0MI
{
    Id = 11,
    Value = 74,
    NullableValue = 213,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 21,
    Value = 45,
    ModelInner = new ByteUInt8E0MI
{
    Id = 19,
    Value = 2,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 23,
    Value = 47,
    ModelInner = new ByteUInt8E0MI
{
    Id = 26,
    Value = 241,
    NullableValue = 240,
},
    NullableValue = 112,
},
            new ByteUInt8E0M
{
    Id = 25,
    Value = 164,
    ModelInner = new ByteUInt8E0MI
{
    Id = 29,
    Value = 134,
    NullableValue = null,
},
    NullableValue = 140,
},
            new ByteUInt8E0M
{
    Id = 32,
    Value = 84,
    ModelInner = new ByteUInt8E0MI
{
    Id = 35,
    Value = 224,
    NullableValue = null,
},
    NullableValue = 254,
},
            new ByteUInt8E0M
{
    Id = 39,
    Value = 47,
    ModelInner = new ByteUInt8E0MI
{
    Id = 39,
    Value = 107,
    NullableValue = 88,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 45,
    Value = 194,
    ModelInner = new ByteUInt8E0MI
{
    Id = 46,
    Value = 144,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 50,
    Value = 35,
    ModelInner = new ByteUInt8E0MI
{
    Id = 54,
    Value = 12,
    NullableValue = null,
},
    NullableValue = 128,
},
            new ByteUInt8E0M
{
    Id = 54,
    Value = 137,
    ModelInner = new ByteUInt8E0MI
{
    Id = 57,
    Value = 54,
    NullableValue = 180,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 60,
    Value = 74,
    ModelInner = new ByteUInt8E0MI
{
    Id = 60,
    Value = 32,
    NullableValue = null,
},
    NullableValue = 99,
},
            new ByteUInt8E0M
{
    Id = 61,
    Value = 157,
    ModelInner = new ByteUInt8E0MI
{
    Id = 67,
    Value = 207,
    NullableValue = null,
},
    NullableValue = 146,
},
            new ByteUInt8E0M
{
    Id = 62,
    Value = 89,
    ModelInner = new ByteUInt8E0MI
{
    Id = 73,
    Value = 65,
    NullableValue = 56,
},
    NullableValue = 195,
},
            new ByteUInt8E0M
{
    Id = 70,
    Value = 230,
    ModelInner = new ByteUInt8E0MI
{
    Id = 77,
    Value = 148,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 72,
    Value = 138,
    ModelInner = new ByteUInt8E0MI
{
    Id = 78,
    Value = 48,
    NullableValue = null,
},
    NullableValue = 181,
},
            new ByteUInt8E0M
{
    Id = 73,
    Value = 131,
    ModelInner = new ByteUInt8E0MI
{
    Id = 80,
    Value = 109,
    NullableValue = 163,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 80,
    Value = 252,
    ModelInner = new ByteUInt8E0MI
{
    Id = 85,
    Value = 100,
    NullableValue = null,
},
    NullableValue = 206,
},
            new ByteUInt8E0M
{
    Id = 85,
    Value = 47,
    ModelInner = new ByteUInt8E0MI
{
    Id = 86,
    Value = 103,
    NullableValue = 42,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 87,
    Value = 118,
    ModelInner = new ByteUInt8E0MI
{
    Id = 89,
    Value = 251,
    NullableValue = 115,
},
    NullableValue = 123,
},
            new ByteUInt8E0M
{
    Id = 93,
    Value = 232,
    ModelInner = new ByteUInt8E0MI
{
    Id = 93,
    Value = 41,
    NullableValue = 19,
},
    NullableValue = 139,
},
            new ByteUInt8E0M
{
    Id = 100,
    Value = 67,
    ModelInner = new ByteUInt8E0MI
{
    Id = 99,
    Value = 26,
    NullableValue = 132,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 103,
    Value = 142,
    ModelInner = new ByteUInt8E0MI
{
    Id = 103,
    Value = 224,
    NullableValue = 254,
},
    NullableValue = 40,
},
            new ByteUInt8E0M
{
    Id = 112,
    Value = 170,
    ModelInner = new ByteUInt8E0MI
{
    Id = 107,
    Value = 108,
    NullableValue = 129,
},
    NullableValue = 76,
},
            new ByteUInt8E0M
{
    Id = 117,
    Value = 228,
    ModelInner = new ByteUInt8E0MI
{
    Id = 109,
    Value = 51,
    NullableValue = 117,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 118,
    Value = 216,
    ModelInner = new ByteUInt8E0MI
{
    Id = 115,
    Value = 251,
    NullableValue = null,
},
    NullableValue = 109,
},
            new ByteUInt8E0M
{
    Id = 127,
    Value = 121,
    ModelInner = new ByteUInt8E0MI
{
    Id = 117,
    Value = 75,
    NullableValue = null,
},
    NullableValue = 63,
},
            new ByteUInt8E0M
{
    Id = 133,
    Value = 19,
    ModelInner = new ByteUInt8E0MI
{
    Id = 124,
    Value = 246,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 142,
    Value = 142,
    ModelInner = new ByteUInt8E0MI
{
    Id = 129,
    Value = 179,
    NullableValue = null,
},
    NullableValue = 202,
},
            new ByteUInt8E0M
{
    Id = 150,
    Value = 222,
    ModelInner = new ByteUInt8E0MI
{
    Id = 136,
    Value = 100,
    NullableValue = 159,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 154,
    Value = 21,
    ModelInner = new ByteUInt8E0MI
{
    Id = 144,
    Value = 131,
    NullableValue = 236,
},
    NullableValue = 124,
},
            new ByteUInt8E0M
{
    Id = 156,
    Value = 2,
    ModelInner = new ByteUInt8E0MI
{
    Id = 147,
    Value = 169,
    NullableValue = 60,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 162,
    Value = 183,
    ModelInner = new ByteUInt8E0MI
{
    Id = 156,
    Value = 208,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 168,
    Value = 97,
    ModelInner = new ByteUInt8E0MI
{
    Id = 157,
    Value = 45,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 176,
    Value = 181,
    ModelInner = new ByteUInt8E0MI
{
    Id = 161,
    Value = 14,
    NullableValue = 212,
},
    NullableValue = 242,
},
            new ByteUInt8E0M
{
    Id = 182,
    Value = 160,
    ModelInner = new ByteUInt8E0MI
{
    Id = 167,
    Value = 208,
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

