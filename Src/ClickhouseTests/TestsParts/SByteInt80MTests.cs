

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

        private readonly SByteInt80M[] _testData = new SByteInt80M[]
        {
            new SByteInt80M
{
    Id = 3,
    Value = 76,
    ModelInner = new SByteInt80MI
{
    Id = 9,
    Value = -108,
    NullableValue = -79,
},
    NullableValue = -102,
},
            new SByteInt80M
{
    Id = 9,
    Value = 37,
    ModelInner = new SByteInt80MI
{
    Id = 13,
    Value = -100,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 12,
    Value = 110,
    ModelInner = new SByteInt80MI
{
    Id = 19,
    Value = -47,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 18,
    Value = 23,
    ModelInner = new SByteInt80MI
{
    Id = 28,
    Value = 6,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 26,
    Value = -99,
    ModelInner = new SByteInt80MI
{
    Id = 32,
    Value = -42,
    NullableValue = 12,
},
    NullableValue = 32,
},
            new SByteInt80M
{
    Id = 31,
    Value = 57,
    ModelInner = new SByteInt80MI
{
    Id = 38,
    Value = 126,
    NullableValue = 57,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 40,
    Value = -77,
    ModelInner = new SByteInt80MI
{
    Id = 46,
    Value = 89,
    NullableValue = null,
},
    NullableValue = -98,
},
            new SByteInt80M
{
    Id = 47,
    Value = 72,
    ModelInner = new SByteInt80MI
{
    Id = 49,
    Value = -94,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 56,
    Value = -94,
    ModelInner = new SByteInt80MI
{
    Id = 58,
    Value = -76,
    NullableValue = -14,
},
    NullableValue = 30,
},
            new SByteInt80M
{
    Id = 59,
    Value = 65,
    ModelInner = new SByteInt80MI
{
    Id = 65,
    Value = -30,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 61,
    Value = 120,
    ModelInner = new SByteInt80MI
{
    Id = 74,
    Value = 100,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 65,
    Value = 92,
    ModelInner = new SByteInt80MI
{
    Id = 79,
    Value = 109,
    NullableValue = 0,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 72,
    Value = -80,
    ModelInner = new SByteInt80MI
{
    Id = 88,
    Value = 93,
    NullableValue = -119,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 75,
    Value = -53,
    ModelInner = new SByteInt80MI
{
    Id = 93,
    Value = -62,
    NullableValue = null,
},
    NullableValue = -28,
},
            new SByteInt80M
{
    Id = 81,
    Value = 13,
    ModelInner = new SByteInt80MI
{
    Id = 96,
    Value = 5,
    NullableValue = 76,
},
    NullableValue = -20,
},
            new SByteInt80M
{
    Id = 82,
    Value = -26,
    ModelInner = new SByteInt80MI
{
    Id = 104,
    Value = -63,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 91,
    Value = 95,
    ModelInner = new SByteInt80MI
{
    Id = 113,
    Value = 107,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 98,
    Value = -86,
    ModelInner = new SByteInt80MI
{
    Id = 120,
    Value = 4,
    NullableValue = -127,
},
    NullableValue = -72,
},
            new SByteInt80M
{
    Id = 103,
    Value = 122,
    ModelInner = new SByteInt80MI
{
    Id = 126,
    Value = -78,
    NullableValue = -76,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 112,
    Value = -50,
    ModelInner = new SByteInt80MI
{
    Id = 129,
    Value = -49,
    NullableValue = null,
},
    NullableValue = -41,
},
            new SByteInt80M
{
    Id = 116,
    Value = -68,
    ModelInner = new SByteInt80MI
{
    Id = 132,
    Value = -86,
    NullableValue = null,
},
    NullableValue = 44,
},
            new SByteInt80M
{
    Id = 122,
    Value = 33,
    ModelInner = new SByteInt80MI
{
    Id = 136,
    Value = -10,
    NullableValue = null,
},
    NullableValue = 17,
},
            new SByteInt80M
{
    Id = 127,
    Value = -72,
    ModelInner = new SByteInt80MI
{
    Id = 142,
    Value = -88,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 128,
    Value = 70,
    ModelInner = new SByteInt80MI
{
    Id = 145,
    Value = -27,
    NullableValue = -100,
},
    NullableValue = -101,
},
            new SByteInt80M
{
    Id = 131,
    Value = -67,
    ModelInner = new SByteInt80MI
{
    Id = 152,
    Value = -13,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 140,
    Value = 78,
    ModelInner = new SByteInt80MI
{
    Id = 157,
    Value = 31,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 144,
    Value = 84,
    ModelInner = new SByteInt80MI
{
    Id = 161,
    Value = 112,
    NullableValue = 84,
},
    NullableValue = 54,
},
            new SByteInt80M
{
    Id = 152,
    Value = 80,
    ModelInner = new SByteInt80MI
{
    Id = 164,
    Value = -103,
    NullableValue = 86,
},
    NullableValue = 73,
},
            new SByteInt80M
{
    Id = 157,
    Value = 61,
    ModelInner = new SByteInt80MI
{
    Id = 166,
    Value = 8,
    NullableValue = -70,
},
    NullableValue = -37,
},
            new SByteInt80M
{
    Id = 158,
    Value = -17,
    ModelInner = new SByteInt80MI
{
    Id = 172,
    Value = 111,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 163,
    Value = 20,
    ModelInner = new SByteInt80MI
{
    Id = 178,
    Value = 31,
    NullableValue = -12,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 167,
    Value = 115,
    ModelInner = new SByteInt80MI
{
    Id = 184,
    Value = 65,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 169,
    Value = -81,
    ModelInner = new SByteInt80MI
{
    Id = 187,
    Value = -95,
    NullableValue = -104,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 171,
    Value = 101,
    ModelInner = new SByteInt80MI
{
    Id = 195,
    Value = 55,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 173,
    Value = -50,
    ModelInner = new SByteInt80MI
{
    Id = 201,
    Value = 19,
    NullableValue = 74,
},
    NullableValue = -115,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.sbyteint80m(
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
FROM gedaqtests.sbyteint80m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(SByteInt80M)],
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
                    SByteInt80M.AssertModel(models[0],_testData[i], false);
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
                    SByteInt80M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

