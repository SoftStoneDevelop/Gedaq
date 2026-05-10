

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
    Id = 4,
    Value = -113,
    ModelInner = new SByteInt80MI
{
    Id = 5,
    Value = -3,
    NullableValue = 124,
},
    NullableValue = 62,
},
            new SByteInt80M
{
    Id = 8,
    Value = -26,
    ModelInner = new SByteInt80MI
{
    Id = 8,
    Value = -50,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 10,
    Value = -102,
    ModelInner = new SByteInt80MI
{
    Id = 16,
    Value = 8,
    NullableValue = 64,
},
    NullableValue = -9,
},
            new SByteInt80M
{
    Id = 11,
    Value = -83,
    ModelInner = new SByteInt80MI
{
    Id = 21,
    Value = -39,
    NullableValue = 36,
},
    NullableValue = 66,
},
            new SByteInt80M
{
    Id = 19,
    Value = -62,
    ModelInner = new SByteInt80MI
{
    Id = 29,
    Value = 103,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 28,
    Value = 12,
    ModelInner = new SByteInt80MI
{
    Id = 31,
    Value = 38,
    NullableValue = -78,
},
    NullableValue = 53,
},
            new SByteInt80M
{
    Id = 29,
    Value = -111,
    ModelInner = new SByteInt80MI
{
    Id = 32,
    Value = -37,
    NullableValue = -5,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 32,
    Value = -38,
    ModelInner = new SByteInt80MI
{
    Id = 40,
    Value = -124,
    NullableValue = 96,
},
    NullableValue = 28,
},
            new SByteInt80M
{
    Id = 35,
    Value = 13,
    ModelInner = new SByteInt80MI
{
    Id = 43,
    Value = 116,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 41,
    Value = 41,
    ModelInner = new SByteInt80MI
{
    Id = 45,
    Value = 55,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 47,
    Value = -60,
    ModelInner = new SByteInt80MI
{
    Id = 54,
    Value = 38,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 52,
    Value = 108,
    ModelInner = new SByteInt80MI
{
    Id = 59,
    Value = -1,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 58,
    Value = -114,
    ModelInner = new SByteInt80MI
{
    Id = 63,
    Value = 52,
    NullableValue = 125,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 62,
    Value = -10,
    ModelInner = new SByteInt80MI
{
    Id = 67,
    Value = -67,
    NullableValue = null,
},
    NullableValue = -103,
},
            new SByteInt80M
{
    Id = 71,
    Value = 12,
    ModelInner = new SByteInt80MI
{
    Id = 76,
    Value = -95,
    NullableValue = -117,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 77,
    Value = 48,
    ModelInner = new SByteInt80MI
{
    Id = 77,
    Value = 89,
    NullableValue = -24,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 85,
    Value = 14,
    ModelInner = new SByteInt80MI
{
    Id = 86,
    Value = 33,
    NullableValue = -18,
},
    NullableValue = -106,
},
            new SByteInt80M
{
    Id = 91,
    Value = 41,
    ModelInner = new SByteInt80MI
{
    Id = 94,
    Value = -38,
    NullableValue = -41,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 99,
    Value = -56,
    ModelInner = new SByteInt80MI
{
    Id = 98,
    Value = 7,
    NullableValue = 119,
},
    NullableValue = -126,
},
            new SByteInt80M
{
    Id = 104,
    Value = 76,
    ModelInner = new SByteInt80MI
{
    Id = 99,
    Value = 41,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 108,
    Value = -14,
    ModelInner = new SByteInt80MI
{
    Id = 101,
    Value = -93,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 112,
    Value = 93,
    ModelInner = new SByteInt80MI
{
    Id = 108,
    Value = 84,
    NullableValue = 60,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 121,
    Value = 75,
    ModelInner = new SByteInt80MI
{
    Id = 117,
    Value = -114,
    NullableValue = -126,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 124,
    Value = -71,
    ModelInner = new SByteInt80MI
{
    Id = 124,
    Value = 34,
    NullableValue = null,
},
    NullableValue = 121,
},
            new SByteInt80M
{
    Id = 129,
    Value = -117,
    ModelInner = new SByteInt80MI
{
    Id = 130,
    Value = 104,
    NullableValue = null,
},
    NullableValue = -49,
},
            new SByteInt80M
{
    Id = 134,
    Value = -6,
    ModelInner = new SByteInt80MI
{
    Id = 139,
    Value = -36,
    NullableValue = null,
},
    NullableValue = -91,
},
            new SByteInt80M
{
    Id = 139,
    Value = -120,
    ModelInner = new SByteInt80MI
{
    Id = 141,
    Value = 100,
    NullableValue = 16,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 143,
    Value = -35,
    ModelInner = new SByteInt80MI
{
    Id = 147,
    Value = 120,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 144,
    Value = -25,
    ModelInner = new SByteInt80MI
{
    Id = 148,
    Value = 35,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 152,
    Value = 15,
    ModelInner = new SByteInt80MI
{
    Id = 157,
    Value = 14,
    NullableValue = null,
},
    NullableValue = 124,
},
            new SByteInt80M
{
    Id = 159,
    Value = 4,
    ModelInner = new SByteInt80MI
{
    Id = 164,
    Value = 65,
    NullableValue = null,
},
    NullableValue = -78,
},
            new SByteInt80M
{
    Id = 167,
    Value = -125,
    ModelInner = new SByteInt80MI
{
    Id = 166,
    Value = -107,
    NullableValue = null,
},
    NullableValue = 7,
},
            new SByteInt80M
{
    Id = 176,
    Value = -122,
    ModelInner = new SByteInt80MI
{
    Id = 175,
    Value = -66,
    NullableValue = null,
},
    NullableValue = 126,
},
            new SByteInt80M
{
    Id = 181,
    Value = -56,
    ModelInner = new SByteInt80MI
{
    Id = 179,
    Value = 59,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt80M
{
    Id = 186,
    Value = -63,
    ModelInner = new SByteInt80MI
{
    Id = 187,
    Value = 104,
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

