

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
    Id = 4,
    Value = 29,
    ModelInner = new ByteUInt80MI
{
    Id = 1,
    Value = 160,
    NullableValue = null,
},
    NullableValue = 156,
},
            new ByteUInt80M
{
    Id = 8,
    Value = 181,
    ModelInner = new ByteUInt80MI
{
    Id = 7,
    Value = 86,
    NullableValue = null,
},
    NullableValue = 65,
},
            new ByteUInt80M
{
    Id = 16,
    Value = 24,
    ModelInner = new ByteUInt80MI
{
    Id = 11,
    Value = 133,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 21,
    Value = 209,
    ModelInner = new ByteUInt80MI
{
    Id = 17,
    Value = 213,
    NullableValue = 36,
},
    NullableValue = 157,
},
            new ByteUInt80M
{
    Id = 30,
    Value = 180,
    ModelInner = new ByteUInt80MI
{
    Id = 23,
    Value = 12,
    NullableValue = null,
},
    NullableValue = 64,
},
            new ByteUInt80M
{
    Id = 39,
    Value = 21,
    ModelInner = new ByteUInt80MI
{
    Id = 27,
    Value = 109,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 45,
    Value = 183,
    ModelInner = new ByteUInt80MI
{
    Id = 30,
    Value = 16,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 53,
    Value = 187,
    ModelInner = new ByteUInt80MI
{
    Id = 34,
    Value = 239,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 56,
    Value = 222,
    ModelInner = new ByteUInt80MI
{
    Id = 35,
    Value = 154,
    NullableValue = 4,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 63,
    Value = 70,
    ModelInner = new ByteUInt80MI
{
    Id = 38,
    Value = 48,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 69,
    Value = 3,
    ModelInner = new ByteUInt80MI
{
    Id = 45,
    Value = 141,
    NullableValue = 249,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 75,
    Value = 88,
    ModelInner = new ByteUInt80MI
{
    Id = 46,
    Value = 133,
    NullableValue = 60,
},
    NullableValue = 2,
},
            new ByteUInt80M
{
    Id = 84,
    Value = 98,
    ModelInner = new ByteUInt80MI
{
    Id = 54,
    Value = 83,
    NullableValue = 62,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 92,
    Value = 205,
    ModelInner = new ByteUInt80MI
{
    Id = 62,
    Value = 145,
    NullableValue = null,
},
    NullableValue = 173,
},
            new ByteUInt80M
{
    Id = 100,
    Value = 177,
    ModelInner = new ByteUInt80MI
{
    Id = 67,
    Value = 6,
    NullableValue = null,
},
    NullableValue = 253,
},
            new ByteUInt80M
{
    Id = 104,
    Value = 82,
    ModelInner = new ByteUInt80MI
{
    Id = 69,
    Value = 132,
    NullableValue = 150,
},
    NullableValue = 252,
},
            new ByteUInt80M
{
    Id = 110,
    Value = 93,
    ModelInner = new ByteUInt80MI
{
    Id = 73,
    Value = 26,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 114,
    Value = 0,
    ModelInner = new ByteUInt80MI
{
    Id = 74,
    Value = 84,
    NullableValue = null,
},
    NullableValue = 44,
},
            new ByteUInt80M
{
    Id = 117,
    Value = 114,
    ModelInner = new ByteUInt80MI
{
    Id = 79,
    Value = 101,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 124,
    Value = 253,
    ModelInner = new ByteUInt80MI
{
    Id = 84,
    Value = 51,
    NullableValue = 72,
},
    NullableValue = 157,
},
            new ByteUInt80M
{
    Id = 128,
    Value = 47,
    ModelInner = new ByteUInt80MI
{
    Id = 93,
    Value = 72,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 130,
    Value = 171,
    ModelInner = new ByteUInt80MI
{
    Id = 96,
    Value = 207,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 131,
    Value = 29,
    ModelInner = new ByteUInt80MI
{
    Id = 103,
    Value = 200,
    NullableValue = null,
},
    NullableValue = 85,
},
            new ByteUInt80M
{
    Id = 138,
    Value = 187,
    ModelInner = new ByteUInt80MI
{
    Id = 104,
    Value = 134,
    NullableValue = 202,
},
    NullableValue = 122,
},
            new ByteUInt80M
{
    Id = 142,
    Value = 33,
    ModelInner = new ByteUInt80MI
{
    Id = 109,
    Value = 174,
    NullableValue = null,
},
    NullableValue = 165,
},
            new ByteUInt80M
{
    Id = 149,
    Value = 48,
    ModelInner = new ByteUInt80MI
{
    Id = 111,
    Value = 194,
    NullableValue = 16,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 155,
    Value = 20,
    ModelInner = new ByteUInt80MI
{
    Id = 117,
    Value = 211,
    NullableValue = 207,
},
    NullableValue = 59,
},
            new ByteUInt80M
{
    Id = 163,
    Value = 88,
    ModelInner = new ByteUInt80MI
{
    Id = 125,
    Value = 106,
    NullableValue = null,
},
    NullableValue = 23,
},
            new ByteUInt80M
{
    Id = 168,
    Value = 51,
    ModelInner = new ByteUInt80MI
{
    Id = 127,
    Value = 160,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 177,
    Value = 232,
    ModelInner = new ByteUInt80MI
{
    Id = 135,
    Value = 170,
    NullableValue = 148,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 185,
    Value = 145,
    ModelInner = new ByteUInt80MI
{
    Id = 140,
    Value = 40,
    NullableValue = 7,
},
    NullableValue = 218,
},
            new ByteUInt80M
{
    Id = 187,
    Value = 46,
    ModelInner = new ByteUInt80MI
{
    Id = 146,
    Value = 144,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 190,
    Value = 46,
    ModelInner = new ByteUInt80MI
{
    Id = 149,
    Value = 156,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 195,
    Value = 40,
    ModelInner = new ByteUInt80MI
{
    Id = 154,
    Value = 4,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt80M
{
    Id = 201,
    Value = 202,
    ModelInner = new ByteUInt80MI
{
    Id = 158,
    Value = 125,
    NullableValue = 229,
},
    NullableValue = 157,
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

