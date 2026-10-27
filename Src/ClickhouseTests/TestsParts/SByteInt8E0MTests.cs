

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
    Id = 4,
    Value = 119,
    ModelInner = new SByteInt8E0MI
{
    Id = 7,
    Value = 75,
    NullableValue = null,
},
    NullableValue = 5,
},
            new SByteInt8E0M
{
    Id = 10,
    Value = 18,
    ModelInner = new SByteInt8E0MI
{
    Id = 14,
    Value = -54,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 12,
    Value = 5,
    ModelInner = new SByteInt8E0MI
{
    Id = 17,
    Value = -13,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 21,
    Value = 99,
    ModelInner = new SByteInt8E0MI
{
    Id = 24,
    Value = 38,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 25,
    Value = -125,
    ModelInner = new SByteInt8E0MI
{
    Id = 28,
    Value = 30,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 32,
    Value = 112,
    ModelInner = new SByteInt8E0MI
{
    Id = 35,
    Value = -113,
    NullableValue = -25,
},
    NullableValue = 125,
},
            new SByteInt8E0M
{
    Id = 35,
    Value = -125,
    ModelInner = new SByteInt8E0MI
{
    Id = 36,
    Value = -23,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 43,
    Value = 8,
    ModelInner = new SByteInt8E0MI
{
    Id = 42,
    Value = 63,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 48,
    Value = -127,
    ModelInner = new SByteInt8E0MI
{
    Id = 48,
    Value = -105,
    NullableValue = null,
},
    NullableValue = 31,
},
            new SByteInt8E0M
{
    Id = 51,
    Value = 63,
    ModelInner = new SByteInt8E0MI
{
    Id = 52,
    Value = -26,
    NullableValue = -97,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 60,
    Value = 50,
    ModelInner = new SByteInt8E0MI
{
    Id = 61,
    Value = 50,
    NullableValue = 114,
},
    NullableValue = 63,
},
            new SByteInt8E0M
{
    Id = 69,
    Value = -31,
    ModelInner = new SByteInt8E0MI
{
    Id = 64,
    Value = -111,
    NullableValue = null,
},
    NullableValue = 80,
},
            new SByteInt8E0M
{
    Id = 70,
    Value = -37,
    ModelInner = new SByteInt8E0MI
{
    Id = 73,
    Value = -109,
    NullableValue = 6,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 74,
    Value = -115,
    ModelInner = new SByteInt8E0MI
{
    Id = 75,
    Value = -83,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 79,
    Value = 36,
    ModelInner = new SByteInt8E0MI
{
    Id = 79,
    Value = 90,
    NullableValue = null,
},
    NullableValue = -58,
},
            new SByteInt8E0M
{
    Id = 84,
    Value = -126,
    ModelInner = new SByteInt8E0MI
{
    Id = 83,
    Value = -58,
    NullableValue = -71,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 91,
    Value = -48,
    ModelInner = new SByteInt8E0MI
{
    Id = 90,
    Value = -75,
    NullableValue = 12,
},
    NullableValue = 42,
},
            new SByteInt8E0M
{
    Id = 98,
    Value = 107,
    ModelInner = new SByteInt8E0MI
{
    Id = 92,
    Value = -5,
    NullableValue = 78,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 101,
    Value = 57,
    ModelInner = new SByteInt8E0MI
{
    Id = 100,
    Value = 65,
    NullableValue = -112,
},
    NullableValue = -63,
},
            new SByteInt8E0M
{
    Id = 104,
    Value = -61,
    ModelInner = new SByteInt8E0MI
{
    Id = 108,
    Value = 24,
    NullableValue = 20,
},
    NullableValue = 114,
},
            new SByteInt8E0M
{
    Id = 113,
    Value = -51,
    ModelInner = new SByteInt8E0MI
{
    Id = 116,
    Value = 25,
    NullableValue = 97,
},
    NullableValue = 56,
},
            new SByteInt8E0M
{
    Id = 120,
    Value = -101,
    ModelInner = new SByteInt8E0MI
{
    Id = 125,
    Value = 125,
    NullableValue = -12,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 126,
    Value = -77,
    ModelInner = new SByteInt8E0MI
{
    Id = 126,
    Value = 116,
    NullableValue = 87,
},
    NullableValue = 87,
},
            new SByteInt8E0M
{
    Id = 131,
    Value = 94,
    ModelInner = new SByteInt8E0MI
{
    Id = 135,
    Value = 124,
    NullableValue = -3,
},
    NullableValue = -74,
},
            new SByteInt8E0M
{
    Id = 137,
    Value = -23,
    ModelInner = new SByteInt8E0MI
{
    Id = 137,
    Value = -107,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 145,
    Value = 39,
    ModelInner = new SByteInt8E0MI
{
    Id = 143,
    Value = 124,
    NullableValue = 45,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 151,
    Value = 124,
    ModelInner = new SByteInt8E0MI
{
    Id = 146,
    Value = 20,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 155,
    Value = -6,
    ModelInner = new SByteInt8E0MI
{
    Id = 155,
    Value = -36,
    NullableValue = -18,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 163,
    Value = 103,
    ModelInner = new SByteInt8E0MI
{
    Id = 159,
    Value = 66,
    NullableValue = null,
},
    NullableValue = -59,
},
            new SByteInt8E0M
{
    Id = 171,
    Value = 43,
    ModelInner = new SByteInt8E0MI
{
    Id = 162,
    Value = 13,
    NullableValue = 53,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 176,
    Value = -87,
    ModelInner = new SByteInt8E0MI
{
    Id = 169,
    Value = -22,
    NullableValue = 117,
},
    NullableValue = -11,
},
            new SByteInt8E0M
{
    Id = 181,
    Value = 121,
    ModelInner = new SByteInt8E0MI
{
    Id = 174,
    Value = 96,
    NullableValue = 68,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 188,
    Value = -52,
    ModelInner = new SByteInt8E0MI
{
    Id = 180,
    Value = 124,
    NullableValue = -55,
},
    NullableValue = 89,
},
            new SByteInt8E0M
{
    Id = 194,
    Value = -2,
    ModelInner = new SByteInt8E0MI
{
    Id = 185,
    Value = -58,
    NullableValue = 36,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 203,
    Value = 59,
    ModelInner = new SByteInt8E0MI
{
    Id = 191,
    Value = 126,
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

