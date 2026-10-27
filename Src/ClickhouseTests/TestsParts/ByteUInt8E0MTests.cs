

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
    Value = 178,
    ModelInner = new ByteUInt8E0MI
{
    Id = 8,
    Value = 111,
    NullableValue = 23,
},
    NullableValue = 92,
},
            new ByteUInt8E0M
{
    Id = 8,
    Value = 212,
    ModelInner = new ByteUInt8E0MI
{
    Id = 13,
    Value = 99,
    NullableValue = null,
},
    NullableValue = 226,
},
            new ByteUInt8E0M
{
    Id = 9,
    Value = 94,
    ModelInner = new ByteUInt8E0MI
{
    Id = 18,
    Value = 15,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 15,
    Value = 147,
    ModelInner = new ByteUInt8E0MI
{
    Id = 22,
    Value = 250,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 17,
    Value = 182,
    ModelInner = new ByteUInt8E0MI
{
    Id = 26,
    Value = 129,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 24,
    Value = 183,
    ModelInner = new ByteUInt8E0MI
{
    Id = 33,
    Value = 249,
    NullableValue = 168,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 28,
    Value = 174,
    ModelInner = new ByteUInt8E0MI
{
    Id = 37,
    Value = 72,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 35,
    Value = 22,
    ModelInner = new ByteUInt8E0MI
{
    Id = 39,
    Value = 212,
    NullableValue = 133,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 37,
    Value = 100,
    ModelInner = new ByteUInt8E0MI
{
    Id = 41,
    Value = 229,
    NullableValue = null,
},
    NullableValue = 188,
},
            new ByteUInt8E0M
{
    Id = 43,
    Value = 188,
    ModelInner = new ByteUInt8E0MI
{
    Id = 45,
    Value = 249,
    NullableValue = null,
},
    NullableValue = 146,
},
            new ByteUInt8E0M
{
    Id = 48,
    Value = 106,
    ModelInner = new ByteUInt8E0MI
{
    Id = 49,
    Value = 32,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 54,
    Value = 248,
    ModelInner = new ByteUInt8E0MI
{
    Id = 53,
    Value = 139,
    NullableValue = 227,
},
    NullableValue = 100,
},
            new ByteUInt8E0M
{
    Id = 59,
    Value = 10,
    ModelInner = new ByteUInt8E0MI
{
    Id = 54,
    Value = 140,
    NullableValue = 173,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 66,
    Value = 240,
    ModelInner = new ByteUInt8E0MI
{
    Id = 60,
    Value = 184,
    NullableValue = 198,
},
    NullableValue = 246,
},
            new ByteUInt8E0M
{
    Id = 70,
    Value = 178,
    ModelInner = new ByteUInt8E0MI
{
    Id = 64,
    Value = 243,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 79,
    Value = 150,
    ModelInner = new ByteUInt8E0MI
{
    Id = 68,
    Value = 211,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 87,
    Value = 245,
    ModelInner = new ByteUInt8E0MI
{
    Id = 70,
    Value = 111,
    NullableValue = 57,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 88,
    Value = 164,
    ModelInner = new ByteUInt8E0MI
{
    Id = 79,
    Value = 58,
    NullableValue = 73,
},
    NullableValue = 203,
},
            new ByteUInt8E0M
{
    Id = 94,
    Value = 44,
    ModelInner = new ByteUInt8E0MI
{
    Id = 80,
    Value = 32,
    NullableValue = 225,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 99,
    Value = 67,
    ModelInner = new ByteUInt8E0MI
{
    Id = 84,
    Value = 207,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 101,
    Value = 70,
    ModelInner = new ByteUInt8E0MI
{
    Id = 90,
    Value = 9,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 103,
    Value = 8,
    ModelInner = new ByteUInt8E0MI
{
    Id = 96,
    Value = 42,
    NullableValue = 7,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 110,
    Value = 240,
    ModelInner = new ByteUInt8E0MI
{
    Id = 102,
    Value = 89,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 116,
    Value = 252,
    ModelInner = new ByteUInt8E0MI
{
    Id = 107,
    Value = 116,
    NullableValue = 36,
},
    NullableValue = 102,
},
            new ByteUInt8E0M
{
    Id = 117,
    Value = 26,
    ModelInner = new ByteUInt8E0MI
{
    Id = 116,
    Value = 42,
    NullableValue = 240,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 126,
    Value = 38,
    ModelInner = new ByteUInt8E0MI
{
    Id = 121,
    Value = 26,
    NullableValue = 173,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 132,
    Value = 249,
    ModelInner = new ByteUInt8E0MI
{
    Id = 125,
    Value = 197,
    NullableValue = 126,
},
    NullableValue = 173,
},
            new ByteUInt8E0M
{
    Id = 137,
    Value = 148,
    ModelInner = new ByteUInt8E0MI
{
    Id = 130,
    Value = 68,
    NullableValue = null,
},
    NullableValue = 156,
},
            new ByteUInt8E0M
{
    Id = 140,
    Value = 84,
    ModelInner = new ByteUInt8E0MI
{
    Id = 137,
    Value = 181,
    NullableValue = null,
},
    NullableValue = 51,
},
            new ByteUInt8E0M
{
    Id = 147,
    Value = 27,
    ModelInner = new ByteUInt8E0MI
{
    Id = 143,
    Value = 129,
    NullableValue = null,
},
    NullableValue = 163,
},
            new ByteUInt8E0M
{
    Id = 154,
    Value = 151,
    ModelInner = new ByteUInt8E0MI
{
    Id = 147,
    Value = 54,
    NullableValue = 63,
},
    NullableValue = 248,
},
            new ByteUInt8E0M
{
    Id = 161,
    Value = 187,
    ModelInner = new ByteUInt8E0MI
{
    Id = 151,
    Value = 43,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 168,
    Value = 87,
    ModelInner = new ByteUInt8E0MI
{
    Id = 156,
    Value = 4,
    NullableValue = 38,
},
    NullableValue = 201,
},
            new ByteUInt8E0M
{
    Id = 171,
    Value = 159,
    ModelInner = new ByteUInt8E0MI
{
    Id = 159,
    Value = 66,
    NullableValue = null,
},
    NullableValue = 51,
},
            new ByteUInt8E0M
{
    Id = 179,
    Value = 62,
    ModelInner = new ByteUInt8E0MI
{
    Id = 166,
    Value = 138,
    NullableValue = 206,
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

