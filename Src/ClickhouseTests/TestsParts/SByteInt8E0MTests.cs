

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
    internal partial interface ISByteSingleTypeInt8
    {
    }
    
    internal partial class SByteSingleTypeInt8 : ISByteSingleTypeInt8
    {


#region TestData

        private readonly SByteInt8E0M[] _testData = new SByteInt8E0M[]
        {
            new SByteInt8E0M
{
    Id = 8,
    Value = -97,
    ModelInner = new SByteInt80MI
{
    Id = 7,
    Value = 113,
    NullableValue = null,
},
    NullableValue = 50,
},
            new SByteInt8E0M
{
    Id = 16,
    Value = 40,
    ModelInner = new SByteInt80MI
{
    Id = 14,
    Value = 83,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 23,
    Value = 45,
    ModelInner = new SByteInt80MI
{
    Id = 21,
    Value = -27,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 31,
    Value = 68,
    ModelInner = new SByteInt80MI
{
    Id = 27,
    Value = 19,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 39,
    Value = 41,
    ModelInner = new SByteInt80MI
{
    Id = 33,
    Value = 43,
    NullableValue = 73,
},
    NullableValue = -127,
},
            new SByteInt8E0M
{
    Id = 42,
    Value = -118,
    ModelInner = new SByteInt80MI
{
    Id = 35,
    Value = -51,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 51,
    Value = 95,
    ModelInner = new SByteInt80MI
{
    Id = 42,
    Value = -128,
    NullableValue = 59,
},
    NullableValue = -25,
},
            new SByteInt8E0M
{
    Id = 52,
    Value = 123,
    ModelInner = new SByteInt80MI
{
    Id = 44,
    Value = -63,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 58,
    Value = 10,
    ModelInner = new SByteInt80MI
{
    Id = 48,
    Value = 58,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 66,
    Value = 66,
    ModelInner = new SByteInt80MI
{
    Id = 52,
    Value = -44,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 72,
    Value = 28,
    ModelInner = new SByteInt80MI
{
    Id = 56,
    Value = -77,
    NullableValue = 74,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 77,
    Value = -24,
    ModelInner = new SByteInt80MI
{
    Id = 64,
    Value = 13,
    NullableValue = -62,
},
    NullableValue = -16,
},
            new SByteInt8E0M
{
    Id = 84,
    Value = -73,
    ModelInner = new SByteInt80MI
{
    Id = 73,
    Value = 94,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 89,
    Value = 50,
    ModelInner = new SByteInt80MI
{
    Id = 79,
    Value = -122,
    NullableValue = -106,
},
    NullableValue = 23,
},
            new SByteInt8E0M
{
    Id = 94,
    Value = 73,
    ModelInner = new SByteInt80MI
{
    Id = 83,
    Value = -75,
    NullableValue = -84,
},
    NullableValue = -8,
},
            new SByteInt8E0M
{
    Id = 102,
    Value = -14,
    ModelInner = new SByteInt80MI
{
    Id = 89,
    Value = -75,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 108,
    Value = 62,
    ModelInner = new SByteInt80MI
{
    Id = 97,
    Value = 63,
    NullableValue = -7,
},
    NullableValue = -124,
},
            new SByteInt8E0M
{
    Id = 115,
    Value = 4,
    ModelInner = new SByteInt80MI
{
    Id = 104,
    Value = -70,
    NullableValue = null,
},
    NullableValue = 95,
},
            new SByteInt8E0M
{
    Id = 124,
    Value = -40,
    ModelInner = new SByteInt80MI
{
    Id = 106,
    Value = 23,
    NullableValue = null,
},
    NullableValue = -45,
},
            new SByteInt8E0M
{
    Id = 131,
    Value = -116,
    ModelInner = new SByteInt80MI
{
    Id = 109,
    Value = 35,
    NullableValue = 108,
},
    NullableValue = -69,
},
            new SByteInt8E0M
{
    Id = 133,
    Value = 18,
    ModelInner = new SByteInt80MI
{
    Id = 113,
    Value = -4,
    NullableValue = -4,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 135,
    Value = -91,
    ModelInner = new SByteInt80MI
{
    Id = 118,
    Value = 65,
    NullableValue = -59,
},
    NullableValue = 51,
},
            new SByteInt8E0M
{
    Id = 140,
    Value = -36,
    ModelInner = new SByteInt80MI
{
    Id = 122,
    Value = -52,
    NullableValue = 90,
},
    NullableValue = 80,
},
            new SByteInt8E0M
{
    Id = 147,
    Value = -83,
    ModelInner = new SByteInt80MI
{
    Id = 130,
    Value = 107,
    NullableValue = null,
},
    NullableValue = -21,
},
            new SByteInt8E0M
{
    Id = 152,
    Value = 114,
    ModelInner = new SByteInt80MI
{
    Id = 136,
    Value = 15,
    NullableValue = null,
},
    NullableValue = -79,
},
            new SByteInt8E0M
{
    Id = 158,
    Value = 123,
    ModelInner = new SByteInt80MI
{
    Id = 137,
    Value = 77,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 167,
    Value = 33,
    ModelInner = new SByteInt80MI
{
    Id = 138,
    Value = 12,
    NullableValue = -23,
},
    NullableValue = -19,
},
            new SByteInt8E0M
{
    Id = 176,
    Value = 102,
    ModelInner = new SByteInt80MI
{
    Id = 139,
    Value = 11,
    NullableValue = -14,
},
    NullableValue = 63,
},
            new SByteInt8E0M
{
    Id = 181,
    Value = -39,
    ModelInner = new SByteInt80MI
{
    Id = 141,
    Value = 37,
    NullableValue = null,
},
    NullableValue = -94,
},
            new SByteInt8E0M
{
    Id = 182,
    Value = -46,
    ModelInner = new SByteInt80MI
{
    Id = 149,
    Value = -9,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 190,
    Value = -87,
    ModelInner = new SByteInt80MI
{
    Id = 158,
    Value = -61,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 193,
    Value = -4,
    ModelInner = new SByteInt80MI
{
    Id = 165,
    Value = -37,
    NullableValue = null,
},
    NullableValue = 52,
},
            new SByteInt8E0M
{
    Id = 199,
    Value = 52,
    ModelInner = new SByteInt80MI
{
    Id = 173,
    Value = 36,
    NullableValue = 34,
},
    NullableValue = 112,
},
            new SByteInt8E0M
{
    Id = 204,
    Value = -52,
    ModelInner = new SByteInt80MI
{
    Id = 178,
    Value = -83,
    NullableValue = 120,
},
    NullableValue = 60,
},
            new SByteInt8E0M
{
    Id = 206,
    Value = 68,
    ModelInner = new SByteInt80MI
{
    Id = 180,
    Value = 19,
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
INSERT INTO gedaqtests.sbyteint8e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Int8}, 
    {mi_id:Int32},
    {mi_value:Int8}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypeInt8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte), 
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
                    await ((ISByteSingleTypeInt8)this).InsertModelDbConnectionAsync(
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
                     ((ISByteSingleTypeInt8)this).InsertModelDbConnection(
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
FROM gedaqtests.sbyteint8e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(SByteInt8E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteSingleTypeInt8)),
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
                    var models = await ((ISByteSingleTypeInt8)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteInt8E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((ISByteSingleTypeInt8)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteInt8E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

