

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
    Id = 2,
    Value = -51,
    ModelInner = new SByteInt8E0MI
{
    Id = 8,
    Value = 39,
    NullableValue = null,
},
    NullableValue = 12,
},
            new SByteInt8E0M
{
    Id = 4,
    Value = 19,
    ModelInner = new SByteInt8E0MI
{
    Id = 12,
    Value = 28,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 9,
    Value = 17,
    ModelInner = new SByteInt8E0MI
{
    Id = 13,
    Value = 71,
    NullableValue = null,
},
    NullableValue = -33,
},
            new SByteInt8E0M
{
    Id = 15,
    Value = 65,
    ModelInner = new SByteInt8E0MI
{
    Id = 20,
    Value = -56,
    NullableValue = null,
},
    NullableValue = 60,
},
            new SByteInt8E0M
{
    Id = 20,
    Value = -21,
    ModelInner = new SByteInt8E0MI
{
    Id = 29,
    Value = 96,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 22,
    Value = -33,
    ModelInner = new SByteInt8E0MI
{
    Id = 37,
    Value = 27,
    NullableValue = -114,
},
    NullableValue = 115,
},
            new SByteInt8E0M
{
    Id = 26,
    Value = -117,
    ModelInner = new SByteInt8E0MI
{
    Id = 39,
    Value = -110,
    NullableValue = 11,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 29,
    Value = -28,
    ModelInner = new SByteInt8E0MI
{
    Id = 42,
    Value = 26,
    NullableValue = -62,
},
    NullableValue = 14,
},
            new SByteInt8E0M
{
    Id = 34,
    Value = 22,
    ModelInner = new SByteInt8E0MI
{
    Id = 50,
    Value = -22,
    NullableValue = null,
},
    NullableValue = 67,
},
            new SByteInt8E0M
{
    Id = 41,
    Value = -36,
    ModelInner = new SByteInt8E0MI
{
    Id = 54,
    Value = -17,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 45,
    Value = -126,
    ModelInner = new SByteInt8E0MI
{
    Id = 59,
    Value = -86,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 54,
    Value = -69,
    ModelInner = new SByteInt8E0MI
{
    Id = 64,
    Value = -68,
    NullableValue = 10,
},
    NullableValue = 57,
},
            new SByteInt8E0M
{
    Id = 59,
    Value = -117,
    ModelInner = new SByteInt8E0MI
{
    Id = 72,
    Value = -7,
    NullableValue = 90,
},
    NullableValue = -114,
},
            new SByteInt8E0M
{
    Id = 61,
    Value = -64,
    ModelInner = new SByteInt8E0MI
{
    Id = 81,
    Value = -77,
    NullableValue = null,
},
    NullableValue = 92,
},
            new SByteInt8E0M
{
    Id = 68,
    Value = 49,
    ModelInner = new SByteInt8E0MI
{
    Id = 88,
    Value = 22,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 77,
    Value = 33,
    ModelInner = new SByteInt8E0MI
{
    Id = 91,
    Value = -71,
    NullableValue = -39,
},
    NullableValue = 124,
},
            new SByteInt8E0M
{
    Id = 81,
    Value = 51,
    ModelInner = new SByteInt8E0MI
{
    Id = 99,
    Value = 37,
    NullableValue = 121,
},
    NullableValue = 36,
},
            new SByteInt8E0M
{
    Id = 86,
    Value = -73,
    ModelInner = new SByteInt8E0MI
{
    Id = 105,
    Value = -11,
    NullableValue = null,
},
    NullableValue = 60,
},
            new SByteInt8E0M
{
    Id = 92,
    Value = 33,
    ModelInner = new SByteInt8E0MI
{
    Id = 110,
    Value = 57,
    NullableValue = -88,
},
    NullableValue = 70,
},
            new SByteInt8E0M
{
    Id = 96,
    Value = -93,
    ModelInner = new SByteInt8E0MI
{
    Id = 118,
    Value = 106,
    NullableValue = null,
},
    NullableValue = 50,
},
            new SByteInt8E0M
{
    Id = 104,
    Value = 111,
    ModelInner = new SByteInt8E0MI
{
    Id = 120,
    Value = -28,
    NullableValue = -109,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 109,
    Value = -93,
    ModelInner = new SByteInt8E0MI
{
    Id = 126,
    Value = 1,
    NullableValue = null,
},
    NullableValue = -14,
},
            new SByteInt8E0M
{
    Id = 110,
    Value = -2,
    ModelInner = new SByteInt8E0MI
{
    Id = 128,
    Value = -97,
    NullableValue = 15,
},
    NullableValue = -111,
},
            new SByteInt8E0M
{
    Id = 119,
    Value = 90,
    ModelInner = new SByteInt8E0MI
{
    Id = 133,
    Value = -72,
    NullableValue = -48,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 120,
    Value = -82,
    ModelInner = new SByteInt8E0MI
{
    Id = 139,
    Value = -118,
    NullableValue = 118,
},
    NullableValue = -117,
},
            new SByteInt8E0M
{
    Id = 122,
    Value = 2,
    ModelInner = new SByteInt8E0MI
{
    Id = 145,
    Value = -114,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 131,
    Value = 91,
    ModelInner = new SByteInt8E0MI
{
    Id = 147,
    Value = 43,
    NullableValue = -65,
},
    NullableValue = 76,
},
            new SByteInt8E0M
{
    Id = 138,
    Value = 110,
    ModelInner = new SByteInt8E0MI
{
    Id = 156,
    Value = -100,
    NullableValue = -80,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 141,
    Value = -119,
    ModelInner = new SByteInt8E0MI
{
    Id = 158,
    Value = 35,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 149,
    Value = 17,
    ModelInner = new SByteInt8E0MI
{
    Id = 166,
    Value = 111,
    NullableValue = 121,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 158,
    Value = -86,
    ModelInner = new SByteInt8E0MI
{
    Id = 169,
    Value = -16,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 159,
    Value = 116,
    ModelInner = new SByteInt8E0MI
{
    Id = 177,
    Value = 120,
    NullableValue = null,
},
    NullableValue = -35,
},
            new SByteInt8E0M
{
    Id = 160,
    Value = 11,
    ModelInner = new SByteInt8E0MI
{
    Id = 180,
    Value = 89,
    NullableValue = -114,
},
    NullableValue = 61,
},
            new SByteInt8E0M
{
    Id = 161,
    Value = 99,
    ModelInner = new SByteInt8E0MI
{
    Id = 187,
    Value = 61,
    NullableValue = 117,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 165,
    Value = -44,
    ModelInner = new SByteInt8E0MI
{
    Id = 190,
    Value = 59,
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

