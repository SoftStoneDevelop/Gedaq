

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
    Id = 9,
    Value = 37,
    ModelInner = new ByteUInt80MI
{
    Id = 6,
    Value = 202,
    NullableValue = 173,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 13,
    Value = 194,
    ModelInner = new ByteUInt80MI
{
    Id = 7,
    Value = 13,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 15,
    Value = 230,
    ModelInner = new ByteUInt80MI
{
    Id = 9,
    Value = 105,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 21,
    Value = 49,
    ModelInner = new ByteUInt80MI
{
    Id = 13,
    Value = 3,
    NullableValue = 97,
},
    NullableValue = 167,
},
            new ByteUInt80M
{
    Id = 26,
    Value = 231,
    ModelInner = new ByteUInt80MI
{
    Id = 18,
    Value = 217,
    NullableValue = null,
},
    NullableValue = 115,
},
            new ByteUInt80M
{
    Id = 28,
    Value = 118,
    ModelInner = new ByteUInt80MI
{
    Id = 21,
    Value = 178,
    NullableValue = null,
},
    NullableValue = 137,
},
            new ByteUInt80M
{
    Id = 35,
    Value = 131,
    ModelInner = new ByteUInt80MI
{
    Id = 23,
    Value = 248,
    NullableValue = 22,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 44,
    Value = 217,
    ModelInner = new ByteUInt80MI
{
    Id = 25,
    Value = 19,
    NullableValue = null,
},
    NullableValue = 97,
},
            new ByteUInt80M
{
    Id = 53,
    Value = 98,
    ModelInner = new ByteUInt80MI
{
    Id = 31,
    Value = 243,
    NullableValue = 18,
},
    NullableValue = 4,
},
            new ByteUInt80M
{
    Id = 58,
    Value = 198,
    ModelInner = new ByteUInt80MI
{
    Id = 33,
    Value = 86,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 65,
    Value = 65,
    ModelInner = new ByteUInt80MI
{
    Id = 38,
    Value = 71,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 68,
    Value = 152,
    ModelInner = new ByteUInt80MI
{
    Id = 39,
    Value = 191,
    NullableValue = 31,
},
    NullableValue = 228,
},
            new ByteUInt80M
{
    Id = 70,
    Value = 29,
    ModelInner = new ByteUInt80MI
{
    Id = 46,
    Value = 142,
    NullableValue = null,
},
    NullableValue = 210,
},
            new ByteUInt80M
{
    Id = 79,
    Value = 158,
    ModelInner = new ByteUInt80MI
{
    Id = 52,
    Value = 61,
    NullableValue = 219,
},
    NullableValue = 214,
},
            new ByteUInt80M
{
    Id = 81,
    Value = 253,
    ModelInner = new ByteUInt80MI
{
    Id = 55,
    Value = 9,
    NullableValue = 212,
},
    NullableValue = 31,
},
            new ByteUInt80M
{
    Id = 82,
    Value = 4,
    ModelInner = new ByteUInt80MI
{
    Id = 64,
    Value = 0,
    NullableValue = 234,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 88,
    Value = 137,
    ModelInner = new ByteUInt80MI
{
    Id = 68,
    Value = 104,
    NullableValue = 3,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 90,
    Value = 222,
    ModelInner = new ByteUInt80MI
{
    Id = 71,
    Value = 194,
    NullableValue = 242,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 95,
    Value = 56,
    ModelInner = new ByteUInt80MI
{
    Id = 77,
    Value = 119,
    NullableValue = 207,
},
    NullableValue = 134,
},
            new ByteUInt80M
{
    Id = 98,
    Value = 129,
    ModelInner = new ByteUInt80MI
{
    Id = 79,
    Value = 187,
    NullableValue = 219,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 103,
    Value = 19,
    ModelInner = new ByteUInt80MI
{
    Id = 88,
    Value = 247,
    NullableValue = null,
},
    NullableValue = 137,
},
            new ByteUInt80M
{
    Id = 108,
    Value = 211,
    ModelInner = new ByteUInt80MI
{
    Id = 94,
    Value = 43,
    NullableValue = null,
},
    NullableValue = 151,
},
            new ByteUInt80M
{
    Id = 113,
    Value = 116,
    ModelInner = new ByteUInt80MI
{
    Id = 95,
    Value = 148,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 116,
    Value = 87,
    ModelInner = new ByteUInt80MI
{
    Id = 104,
    Value = 0,
    NullableValue = 68,
},
    NullableValue = 13,
},
            new ByteUInt80M
{
    Id = 124,
    Value = 132,
    ModelInner = new ByteUInt80MI
{
    Id = 105,
    Value = 17,
    NullableValue = 81,
},
    NullableValue = 21,
},
            new ByteUInt80M
{
    Id = 131,
    Value = 214,
    ModelInner = new ByteUInt80MI
{
    Id = 110,
    Value = 179,
    NullableValue = 215,
},
    NullableValue = 161,
},
            new ByteUInt80M
{
    Id = 140,
    Value = 27,
    ModelInner = new ByteUInt80MI
{
    Id = 117,
    Value = 6,
    NullableValue = 2,
},
    NullableValue = 200,
},
            new ByteUInt80M
{
    Id = 148,
    Value = 230,
    ModelInner = new ByteUInt80MI
{
    Id = 125,
    Value = 95,
    NullableValue = null,
},
    NullableValue = 134,
},
            new ByteUInt80M
{
    Id = 153,
    Value = 41,
    ModelInner = new ByteUInt80MI
{
    Id = 129,
    Value = 83,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 157,
    Value = 234,
    ModelInner = new ByteUInt80MI
{
    Id = 132,
    Value = 106,
    NullableValue = 46,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 163,
    Value = 127,
    ModelInner = new ByteUInt80MI
{
    Id = 136,
    Value = 215,
    NullableValue = 64,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 166,
    Value = 195,
    ModelInner = new ByteUInt80MI
{
    Id = 144,
    Value = 146,
    NullableValue = 75,
},
    NullableValue = 150,
},
            new ByteUInt80M
{
    Id = 173,
    Value = 123,
    ModelInner = new ByteUInt80MI
{
    Id = 152,
    Value = 133,
    NullableValue = 95,
},
    NullableValue = 23,
},
            new ByteUInt80M
{
    Id = 179,
    Value = 5,
    ModelInner = new ByteUInt80MI
{
    Id = 160,
    Value = 169,
    NullableValue = 149,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 183,
    Value = 169,
    ModelInner = new ByteUInt80MI
{
    Id = 169,
    Value = 149,
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

