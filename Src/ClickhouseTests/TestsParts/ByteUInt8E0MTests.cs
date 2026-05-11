

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
    Value = 39,
    ModelInner = new ByteUInt8E0MI
{
    Id = 4,
    Value = 61,
    NullableValue = 221,
},
    NullableValue = 237,
},
            new ByteUInt8E0M
{
    Id = 8,
    Value = 125,
    ModelInner = new ByteUInt8E0MI
{
    Id = 6,
    Value = 45,
    NullableValue = null,
},
    NullableValue = 167,
},
            new ByteUInt8E0M
{
    Id = 17,
    Value = 231,
    ModelInner = new ByteUInt8E0MI
{
    Id = 14,
    Value = 199,
    NullableValue = 197,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 23,
    Value = 117,
    ModelInner = new ByteUInt8E0MI
{
    Id = 23,
    Value = 175,
    NullableValue = 87,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 27,
    Value = 84,
    ModelInner = new ByteUInt8E0MI
{
    Id = 30,
    Value = 185,
    NullableValue = null,
},
    NullableValue = 132,
},
            new ByteUInt8E0M
{
    Id = 28,
    Value = 185,
    ModelInner = new ByteUInt8E0MI
{
    Id = 34,
    Value = 209,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 29,
    Value = 87,
    ModelInner = new ByteUInt8E0MI
{
    Id = 43,
    Value = 131,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 31,
    Value = 170,
    ModelInner = new ByteUInt8E0MI
{
    Id = 52,
    Value = 214,
    NullableValue = null,
},
    NullableValue = 216,
},
            new ByteUInt8E0M
{
    Id = 38,
    Value = 209,
    ModelInner = new ByteUInt8E0MI
{
    Id = 53,
    Value = 79,
    NullableValue = null,
},
    NullableValue = 10,
},
            new ByteUInt8E0M
{
    Id = 39,
    Value = 135,
    ModelInner = new ByteUInt8E0MI
{
    Id = 62,
    Value = 142,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 41,
    Value = 243,
    ModelInner = new ByteUInt8E0MI
{
    Id = 63,
    Value = 45,
    NullableValue = null,
},
    NullableValue = 119,
},
            new ByteUInt8E0M
{
    Id = 46,
    Value = 161,
    ModelInner = new ByteUInt8E0MI
{
    Id = 69,
    Value = 30,
    NullableValue = 154,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 53,
    Value = 31,
    ModelInner = new ByteUInt8E0MI
{
    Id = 72,
    Value = 251,
    NullableValue = 110,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 57,
    Value = 202,
    ModelInner = new ByteUInt8E0MI
{
    Id = 81,
    Value = 190,
    NullableValue = 232,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 64,
    Value = 3,
    ModelInner = new ByteUInt8E0MI
{
    Id = 86,
    Value = 64,
    NullableValue = 182,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 72,
    Value = 77,
    ModelInner = new ByteUInt8E0MI
{
    Id = 90,
    Value = 225,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 80,
    Value = 245,
    ModelInner = new ByteUInt8E0MI
{
    Id = 98,
    Value = 160,
    NullableValue = 73,
},
    NullableValue = 52,
},
            new ByteUInt8E0M
{
    Id = 81,
    Value = 181,
    ModelInner = new ByteUInt8E0MI
{
    Id = 101,
    Value = 60,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 84,
    Value = 157,
    ModelInner = new ByteUInt8E0MI
{
    Id = 104,
    Value = 202,
    NullableValue = 249,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 86,
    Value = 169,
    ModelInner = new ByteUInt8E0MI
{
    Id = 109,
    Value = 196,
    NullableValue = 166,
},
    NullableValue = 41,
},
            new ByteUInt8E0M
{
    Id = 87,
    Value = 65,
    ModelInner = new ByteUInt8E0MI
{
    Id = 115,
    Value = 192,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 96,
    Value = 225,
    ModelInner = new ByteUInt8E0MI
{
    Id = 118,
    Value = 59,
    NullableValue = 244,
},
    NullableValue = 31,
},
            new ByteUInt8E0M
{
    Id = 102,
    Value = 246,
    ModelInner = new ByteUInt8E0MI
{
    Id = 121,
    Value = 161,
    NullableValue = 136,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 106,
    Value = 54,
    ModelInner = new ByteUInt8E0MI
{
    Id = 129,
    Value = 199,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 111,
    Value = 180,
    ModelInner = new ByteUInt8E0MI
{
    Id = 131,
    Value = 92,
    NullableValue = null,
},
    NullableValue = 149,
},
            new ByteUInt8E0M
{
    Id = 120,
    Value = 141,
    ModelInner = new ByteUInt8E0MI
{
    Id = 132,
    Value = 137,
    NullableValue = 219,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 126,
    Value = 152,
    ModelInner = new ByteUInt8E0MI
{
    Id = 141,
    Value = 31,
    NullableValue = null,
},
    NullableValue = 67,
},
            new ByteUInt8E0M
{
    Id = 131,
    Value = 192,
    ModelInner = new ByteUInt8E0MI
{
    Id = 147,
    Value = 58,
    NullableValue = null,
},
    NullableValue = 32,
},
            new ByteUInt8E0M
{
    Id = 133,
    Value = 160,
    ModelInner = new ByteUInt8E0MI
{
    Id = 150,
    Value = 108,
    NullableValue = 99,
},
    NullableValue = 95,
},
            new ByteUInt8E0M
{
    Id = 137,
    Value = 153,
    ModelInner = new ByteUInt8E0MI
{
    Id = 155,
    Value = 107,
    NullableValue = null,
},
    NullableValue = 60,
},
            new ByteUInt8E0M
{
    Id = 142,
    Value = 29,
    ModelInner = new ByteUInt8E0MI
{
    Id = 159,
    Value = 223,
    NullableValue = null,
},
    NullableValue = 67,
},
            new ByteUInt8E0M
{
    Id = 146,
    Value = 36,
    ModelInner = new ByteUInt8E0MI
{
    Id = 168,
    Value = 15,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 149,
    Value = 121,
    ModelInner = new ByteUInt8E0MI
{
    Id = 176,
    Value = 191,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 150,
    Value = 152,
    ModelInner = new ByteUInt8E0MI
{
    Id = 178,
    Value = 146,
    NullableValue = 158,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 152,
    Value = 136,
    ModelInner = new ByteUInt8E0MI
{
    Id = 187,
    Value = 71,
    NullableValue = 21,
},
    NullableValue = 193,
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

