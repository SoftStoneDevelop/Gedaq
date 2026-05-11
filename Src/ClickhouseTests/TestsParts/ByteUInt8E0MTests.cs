

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
    Id = 2,
    Value = 59,
    ModelInner = new ByteUInt8E0MI
{
    Id = 5,
    Value = 87,
    NullableValue = 139,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 11,
    Value = 42,
    ModelInner = new ByteUInt8E0MI
{
    Id = 13,
    Value = 121,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 19,
    Value = 39,
    ModelInner = new ByteUInt8E0MI
{
    Id = 20,
    Value = 207,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 21,
    Value = 139,
    ModelInner = new ByteUInt8E0MI
{
    Id = 29,
    Value = 175,
    NullableValue = null,
},
    NullableValue = 80,
},
            new ByteUInt8E0M
{
    Id = 26,
    Value = 2,
    ModelInner = new ByteUInt8E0MI
{
    Id = 38,
    Value = 246,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 27,
    Value = 103,
    ModelInner = new ByteUInt8E0MI
{
    Id = 45,
    Value = 115,
    NullableValue = null,
},
    NullableValue = 39,
},
            new ByteUInt8E0M
{
    Id = 32,
    Value = 33,
    ModelInner = new ByteUInt8E0MI
{
    Id = 53,
    Value = 198,
    NullableValue = 46,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 33,
    Value = 96,
    ModelInner = new ByteUInt8E0MI
{
    Id = 54,
    Value = 230,
    NullableValue = null,
},
    NullableValue = 51,
},
            new ByteUInt8E0M
{
    Id = 37,
    Value = 23,
    ModelInner = new ByteUInt8E0MI
{
    Id = 59,
    Value = 11,
    NullableValue = 214,
},
    NullableValue = 174,
},
            new ByteUInt8E0M
{
    Id = 45,
    Value = 8,
    ModelInner = new ByteUInt8E0MI
{
    Id = 67,
    Value = 127,
    NullableValue = null,
},
    NullableValue = 203,
},
            new ByteUInt8E0M
{
    Id = 51,
    Value = 184,
    ModelInner = new ByteUInt8E0MI
{
    Id = 71,
    Value = 134,
    NullableValue = 112,
},
    NullableValue = 113,
},
            new ByteUInt8E0M
{
    Id = 59,
    Value = 162,
    ModelInner = new ByteUInt8E0MI
{
    Id = 76,
    Value = 137,
    NullableValue = 107,
},
    NullableValue = 223,
},
            new ByteUInt8E0M
{
    Id = 63,
    Value = 226,
    ModelInner = new ByteUInt8E0MI
{
    Id = 80,
    Value = 20,
    NullableValue = null,
},
    NullableValue = 38,
},
            new ByteUInt8E0M
{
    Id = 69,
    Value = 104,
    ModelInner = new ByteUInt8E0MI
{
    Id = 88,
    Value = 135,
    NullableValue = null,
},
    NullableValue = 217,
},
            new ByteUInt8E0M
{
    Id = 74,
    Value = 28,
    ModelInner = new ByteUInt8E0MI
{
    Id = 92,
    Value = 144,
    NullableValue = null,
},
    NullableValue = 181,
},
            new ByteUInt8E0M
{
    Id = 76,
    Value = 185,
    ModelInner = new ByteUInt8E0MI
{
    Id = 93,
    Value = 84,
    NullableValue = 20,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 85,
    Value = 232,
    ModelInner = new ByteUInt8E0MI
{
    Id = 100,
    Value = 18,
    NullableValue = 166,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 89,
    Value = 184,
    ModelInner = new ByteUInt8E0MI
{
    Id = 102,
    Value = 112,
    NullableValue = null,
},
    NullableValue = 243,
},
            new ByteUInt8E0M
{
    Id = 92,
    Value = 177,
    ModelInner = new ByteUInt8E0MI
{
    Id = 110,
    Value = 28,
    NullableValue = null,
},
    NullableValue = 54,
},
            new ByteUInt8E0M
{
    Id = 95,
    Value = 194,
    ModelInner = new ByteUInt8E0MI
{
    Id = 114,
    Value = 205,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 98,
    Value = 43,
    ModelInner = new ByteUInt8E0MI
{
    Id = 115,
    Value = 12,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 100,
    Value = 156,
    ModelInner = new ByteUInt8E0MI
{
    Id = 120,
    Value = 53,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 107,
    Value = 172,
    ModelInner = new ByteUInt8E0MI
{
    Id = 124,
    Value = 126,
    NullableValue = 162,
},
    NullableValue = 180,
},
            new ByteUInt8E0M
{
    Id = 110,
    Value = 46,
    ModelInner = new ByteUInt8E0MI
{
    Id = 131,
    Value = 96,
    NullableValue = 231,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 119,
    Value = 183,
    ModelInner = new ByteUInt8E0MI
{
    Id = 138,
    Value = 252,
    NullableValue = 22,
},
    NullableValue = 2,
},
            new ByteUInt8E0M
{
    Id = 128,
    Value = 65,
    ModelInner = new ByteUInt8E0MI
{
    Id = 142,
    Value = 13,
    NullableValue = 42,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 134,
    Value = 59,
    ModelInner = new ByteUInt8E0MI
{
    Id = 149,
    Value = 236,
    NullableValue = 122,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 137,
    Value = 90,
    ModelInner = new ByteUInt8E0MI
{
    Id = 157,
    Value = 227,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 142,
    Value = 247,
    ModelInner = new ByteUInt8E0MI
{
    Id = 164,
    Value = 118,
    NullableValue = 251,
},
    NullableValue = 65,
},
            new ByteUInt8E0M
{
    Id = 145,
    Value = 43,
    ModelInner = new ByteUInt8E0MI
{
    Id = 165,
    Value = 215,
    NullableValue = null,
},
    NullableValue = 54,
},
            new ByteUInt8E0M
{
    Id = 154,
    Value = 226,
    ModelInner = new ByteUInt8E0MI
{
    Id = 169,
    Value = 169,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 157,
    Value = 180,
    ModelInner = new ByteUInt8E0MI
{
    Id = 171,
    Value = 247,
    NullableValue = 34,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 162,
    Value = 235,
    ModelInner = new ByteUInt8E0MI
{
    Id = 175,
    Value = 185,
    NullableValue = 227,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 167,
    Value = 227,
    ModelInner = new ByteUInt8E0MI
{
    Id = 181,
    Value = 25,
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteUInt8E0M
{
    Id = 170,
    Value = 171,
    ModelInner = new ByteUInt8E0MI
{
    Id = 185,
    Value = 42,
    NullableValue = null,
},
    NullableValue = 24,
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

