

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
    Id = 4,
    Value = 78,
    ModelInner = new ByteUInt8E0MI
{
    Id = 5,
    Value = 100,
    NullableValue = 2,
},
    NullableValue = 143,
},
            new ByteUInt8E0M
{
    Id = 12,
    Value = 87,
    ModelInner = new ByteUInt8E0MI
{
    Id = 7,
    Value = 196,
    NullableValue = null,
},
    NullableValue = 87,
},
            new ByteUInt8E0M
{
    Id = 20,
    Value = 28,
    ModelInner = new ByteUInt8E0MI
{
    Id = 13,
    Value = 130,
    NullableValue = null,
},
    NullableValue = 127,
},
            new ByteUInt8E0M
{
    Id = 21,
    Value = 194,
    ModelInner = new ByteUInt8E0MI
{
    Id = 21,
    Value = 51,
    NullableValue = 126,
},
    NullableValue = 128,
},
            new ByteUInt8E0M
{
    Id = 23,
    Value = 20,
    ModelInner = new ByteUInt8E0MI
{
    Id = 25,
    Value = 186,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 27,
    Value = 162,
    ModelInner = new ByteUInt8E0MI
{
    Id = 33,
    Value = 249,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 29,
    Value = 140,
    ModelInner = new ByteUInt8E0MI
{
    Id = 41,
    Value = 8,
    NullableValue = 13,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 36,
    Value = 42,
    ModelInner = new ByteUInt8E0MI
{
    Id = 50,
    Value = 66,
    NullableValue = 64,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 42,
    Value = 163,
    ModelInner = new ByteUInt8E0MI
{
    Id = 52,
    Value = 34,
    NullableValue = null,
},
    NullableValue = 101,
},
            new ByteUInt8E0M
{
    Id = 47,
    Value = 205,
    ModelInner = new ByteUInt8E0MI
{
    Id = 58,
    Value = 162,
    NullableValue = 156,
},
    NullableValue = 199,
},
            new ByteUInt8E0M
{
    Id = 56,
    Value = 75,
    ModelInner = new ByteUInt8E0MI
{
    Id = 61,
    Value = 54,
    NullableValue = 219,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 61,
    Value = 94,
    ModelInner = new ByteUInt8E0MI
{
    Id = 62,
    Value = 245,
    NullableValue = 41,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 68,
    Value = 105,
    ModelInner = new ByteUInt8E0MI
{
    Id = 70,
    Value = 63,
    NullableValue = 58,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 73,
    Value = 164,
    ModelInner = new ByteUInt8E0MI
{
    Id = 77,
    Value = 107,
    NullableValue = null,
},
    NullableValue = 172,
},
            new ByteUInt8E0M
{
    Id = 81,
    Value = 120,
    ModelInner = new ByteUInt8E0MI
{
    Id = 85,
    Value = 250,
    NullableValue = null,
},
    NullableValue = 215,
},
            new ByteUInt8E0M
{
    Id = 88,
    Value = 105,
    ModelInner = new ByteUInt8E0MI
{
    Id = 92,
    Value = 118,
    NullableValue = 254,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 90,
    Value = 171,
    ModelInner = new ByteUInt8E0MI
{
    Id = 95,
    Value = 71,
    NullableValue = 35,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 91,
    Value = 126,
    ModelInner = new ByteUInt8E0MI
{
    Id = 100,
    Value = 78,
    NullableValue = 58,
},
    NullableValue = 210,
},
            new ByteUInt8E0M
{
    Id = 99,
    Value = 140,
    ModelInner = new ByteUInt8E0MI
{
    Id = 103,
    Value = 103,
    NullableValue = 139,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 105,
    Value = 147,
    ModelInner = new ByteUInt8E0MI
{
    Id = 108,
    Value = 141,
    NullableValue = 226,
},
    NullableValue = 48,
},
            new ByteUInt8E0M
{
    Id = 111,
    Value = 8,
    ModelInner = new ByteUInt8E0MI
{
    Id = 110,
    Value = 63,
    NullableValue = null,
},
    NullableValue = 99,
},
            new ByteUInt8E0M
{
    Id = 114,
    Value = 224,
    ModelInner = new ByteUInt8E0MI
{
    Id = 114,
    Value = 122,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 122,
    Value = 157,
    ModelInner = new ByteUInt8E0MI
{
    Id = 123,
    Value = 14,
    NullableValue = 68,
},
    NullableValue = 22,
},
            new ByteUInt8E0M
{
    Id = 130,
    Value = 190,
    ModelInner = new ByteUInt8E0MI
{
    Id = 128,
    Value = 84,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 135,
    Value = 186,
    ModelInner = new ByteUInt8E0MI
{
    Id = 134,
    Value = 111,
    NullableValue = null,
},
    NullableValue = 136,
},
            new ByteUInt8E0M
{
    Id = 137,
    Value = 154,
    ModelInner = new ByteUInt8E0MI
{
    Id = 143,
    Value = 5,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 144,
    Value = 220,
    ModelInner = new ByteUInt8E0MI
{
    Id = 145,
    Value = 206,
    NullableValue = null,
},
    NullableValue = 86,
},
            new ByteUInt8E0M
{
    Id = 151,
    Value = 157,
    ModelInner = new ByteUInt8E0MI
{
    Id = 152,
    Value = 57,
    NullableValue = 246,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 152,
    Value = 203,
    ModelInner = new ByteUInt8E0MI
{
    Id = 157,
    Value = 147,
    NullableValue = null,
},
    NullableValue = 129,
},
            new ByteUInt8E0M
{
    Id = 158,
    Value = 139,
    ModelInner = new ByteUInt8E0MI
{
    Id = 164,
    Value = 42,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 159,
    Value = 99,
    ModelInner = new ByteUInt8E0MI
{
    Id = 172,
    Value = 31,
    NullableValue = null,
},
    NullableValue = 112,
},
            new ByteUInt8E0M
{
    Id = 166,
    Value = 87,
    ModelInner = new ByteUInt8E0MI
{
    Id = 178,
    Value = 134,
    NullableValue = null,
},
    NullableValue = 200,
},
            new ByteUInt8E0M
{
    Id = 174,
    Value = 135,
    ModelInner = new ByteUInt8E0MI
{
    Id = 181,
    Value = 18,
    NullableValue = 171,
},
    NullableValue = 17,
},
            new ByteUInt8E0M
{
    Id = 180,
    Value = 68,
    ModelInner = new ByteUInt8E0MI
{
    Id = 185,
    Value = 180,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 182,
    Value = 2,
    ModelInner = new ByteUInt8E0MI
{
    Id = 190,
    Value = 75,
    NullableValue = 191,
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

