

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
    Id = 3,
    Value = -73,
    ModelInner = new SByteInt8E0MI
{
    Id = 5,
    Value = -35,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 7,
    Value = 3,
    ModelInner = new SByteInt8E0MI
{
    Id = 13,
    Value = -55,
    NullableValue = -39,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 9,
    Value = -114,
    ModelInner = new SByteInt8E0MI
{
    Id = 17,
    Value = -42,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 17,
    Value = -18,
    ModelInner = new SByteInt8E0MI
{
    Id = 20,
    Value = -125,
    NullableValue = -100,
},
    NullableValue = 116,
},
            new SByteInt8E0M
{
    Id = 23,
    Value = 25,
    ModelInner = new SByteInt8E0MI
{
    Id = 26,
    Value = 67,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 29,
    Value = -33,
    ModelInner = new SByteInt8E0MI
{
    Id = 32,
    Value = -83,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 34,
    Value = -122,
    ModelInner = new SByteInt8E0MI
{
    Id = 34,
    Value = 97,
    NullableValue = null,
},
    NullableValue = 106,
},
            new SByteInt8E0M
{
    Id = 40,
    Value = -19,
    ModelInner = new SByteInt8E0MI
{
    Id = 37,
    Value = -71,
    NullableValue = -55,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 42,
    Value = 94,
    ModelInner = new SByteInt8E0MI
{
    Id = 38,
    Value = 74,
    NullableValue = null,
},
    NullableValue = -115,
},
            new SByteInt8E0M
{
    Id = 45,
    Value = 58,
    ModelInner = new SByteInt8E0MI
{
    Id = 47,
    Value = 111,
    NullableValue = -48,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 52,
    Value = 64,
    ModelInner = new SByteInt8E0MI
{
    Id = 56,
    Value = 8,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 60,
    Value = 15,
    ModelInner = new SByteInt8E0MI
{
    Id = 59,
    Value = -50,
    NullableValue = null,
},
    NullableValue = 35,
},
            new SByteInt8E0M
{
    Id = 66,
    Value = -83,
    ModelInner = new SByteInt8E0MI
{
    Id = 66,
    Value = 56,
    NullableValue = null,
},
    NullableValue = 32,
},
            new SByteInt8E0M
{
    Id = 67,
    Value = 48,
    ModelInner = new SByteInt8E0MI
{
    Id = 73,
    Value = -16,
    NullableValue = 62,
},
    NullableValue = -44,
},
            new SByteInt8E0M
{
    Id = 75,
    Value = -45,
    ModelInner = new SByteInt8E0MI
{
    Id = 77,
    Value = -61,
    NullableValue = 123,
},
    NullableValue = -5,
},
            new SByteInt8E0M
{
    Id = 79,
    Value = 90,
    ModelInner = new SByteInt8E0MI
{
    Id = 84,
    Value = 121,
    NullableValue = null,
},
    NullableValue = -50,
},
            new SByteInt8E0M
{
    Id = 81,
    Value = 50,
    ModelInner = new SByteInt8E0MI
{
    Id = 89,
    Value = 43,
    NullableValue = -107,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 86,
    Value = 125,
    ModelInner = new SByteInt8E0MI
{
    Id = 96,
    Value = 19,
    NullableValue = null,
},
    NullableValue = -22,
},
            new SByteInt8E0M
{
    Id = 91,
    Value = 25,
    ModelInner = new SByteInt8E0MI
{
    Id = 105,
    Value = 66,
    NullableValue = null,
},
    NullableValue = 27,
},
            new SByteInt8E0M
{
    Id = 95,
    Value = 99,
    ModelInner = new SByteInt8E0MI
{
    Id = 111,
    Value = 124,
    NullableValue = null,
},
    NullableValue = -8,
},
            new SByteInt8E0M
{
    Id = 101,
    Value = -113,
    ModelInner = new SByteInt8E0MI
{
    Id = 114,
    Value = -110,
    NullableValue = null,
},
    NullableValue = 109,
},
            new SByteInt8E0M
{
    Id = 103,
    Value = -110,
    ModelInner = new SByteInt8E0MI
{
    Id = 122,
    Value = 84,
    NullableValue = -23,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 111,
    Value = 21,
    ModelInner = new SByteInt8E0MI
{
    Id = 124,
    Value = 13,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 113,
    Value = -24,
    ModelInner = new SByteInt8E0MI
{
    Id = 131,
    Value = 79,
    NullableValue = 74,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 121,
    Value = -45,
    ModelInner = new SByteInt8E0MI
{
    Id = 139,
    Value = 97,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 129,
    Value = 67,
    ModelInner = new SByteInt8E0MI
{
    Id = 145,
    Value = -25,
    NullableValue = null,
},
    NullableValue = -56,
},
            new SByteInt8E0M
{
    Id = 133,
    Value = 109,
    ModelInner = new SByteInt8E0MI
{
    Id = 148,
    Value = -51,
    NullableValue = -69,
},
    NullableValue = -51,
},
            new SByteInt8E0M
{
    Id = 134,
    Value = -115,
    ModelInner = new SByteInt8E0MI
{
    Id = 151,
    Value = 58,
    NullableValue = null,
},
    NullableValue = -80,
},
            new SByteInt8E0M
{
    Id = 141,
    Value = -117,
    ModelInner = new SByteInt8E0MI
{
    Id = 160,
    Value = 86,
    NullableValue = 55,
},
    NullableValue = 70,
},
            new SByteInt8E0M
{
    Id = 148,
    Value = 70,
    ModelInner = new SByteInt8E0MI
{
    Id = 163,
    Value = -57,
    NullableValue = -15,
},
    NullableValue = 102,
},
            new SByteInt8E0M
{
    Id = 156,
    Value = -76,
    ModelInner = new SByteInt8E0MI
{
    Id = 168,
    Value = 113,
    NullableValue = null,
},
    NullableValue = 65,
},
            new SByteInt8E0M
{
    Id = 163,
    Value = -33,
    ModelInner = new SByteInt8E0MI
{
    Id = 172,
    Value = 47,
    NullableValue = 97,
},
    NullableValue = -2,
},
            new SByteInt8E0M
{
    Id = 165,
    Value = 25,
    ModelInner = new SByteInt8E0MI
{
    Id = 181,
    Value = -108,
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteInt8E0M
{
    Id = 168,
    Value = -121,
    ModelInner = new SByteInt8E0MI
{
    Id = 184,
    Value = -31,
    NullableValue = -15,
},
    NullableValue = 41,
},
            new SByteInt8E0M
{
    Id = 170,
    Value = 0,
    ModelInner = new SByteInt8E0MI
{
    Id = 189,
    Value = 47,
    NullableValue = -92,
},
    NullableValue = -26,
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

