

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
    internal partial interface IUInt16SingleTypeUInt16
    {
    }
    
    internal partial class UInt16SingleTypeUInt16 : IUInt16SingleTypeUInt16
    {


#region TestData

        private readonly UInt16UInt16E0M[] _testData = new UInt16UInt16E0M[]
        {
            new UInt16UInt16E0M
{
    Id = 6,
    Value = 56028,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 5,
    Value = 31556,
    NullableValue = null,
},
    NullableValue = 38349,
},
            new UInt16UInt16E0M
{
    Id = 10,
    Value = 14428,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 8,
    Value = 45442,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 18,
    Value = 1807,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 16,
    Value = 59723,
    NullableValue = null,
},
    NullableValue = 52528,
},
            new UInt16UInt16E0M
{
    Id = 20,
    Value = 40618,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 25,
    Value = 43425,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 28,
    Value = 63452,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 29,
    Value = 22443,
    NullableValue = null,
},
    NullableValue = 43299,
},
            new UInt16UInt16E0M
{
    Id = 32,
    Value = 15121,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 36,
    Value = 64151,
    NullableValue = 33868,
},
    NullableValue = 33235,
},
            new UInt16UInt16E0M
{
    Id = 37,
    Value = 51706,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 41,
    Value = 20134,
    NullableValue = 35024,
},
    NullableValue = 52218,
},
            new UInt16UInt16E0M
{
    Id = 38,
    Value = 32748,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 49,
    Value = 3662,
    NullableValue = 53570,
},
    NullableValue = 23591,
},
            new UInt16UInt16E0M
{
    Id = 43,
    Value = 55185,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 56,
    Value = 24712,
    NullableValue = 17824,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 45,
    Value = 39018,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 64,
    Value = 1973,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 51,
    Value = 50576,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 66,
    Value = 52188,
    NullableValue = null,
},
    NullableValue = 24132,
},
            new UInt16UInt16E0M
{
    Id = 56,
    Value = 16983,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 69,
    Value = 35208,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 61,
    Value = 14711,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 73,
    Value = 25424,
    NullableValue = 7672,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 69,
    Value = 61488,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 81,
    Value = 14810,
    NullableValue = 12669,
},
    NullableValue = 1800,
},
            new UInt16UInt16E0M
{
    Id = 71,
    Value = 13343,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 82,
    Value = 3069,
    NullableValue = null,
},
    NullableValue = 30420,
},
            new UInt16UInt16E0M
{
    Id = 79,
    Value = 41989,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 85,
    Value = 10466,
    NullableValue = 43930,
},
    NullableValue = 42417,
},
            new UInt16UInt16E0M
{
    Id = 83,
    Value = 401,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 94,
    Value = 38368,
    NullableValue = 58856,
},
    NullableValue = 54426,
},
            new UInt16UInt16E0M
{
    Id = 91,
    Value = 35878,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 100,
    Value = 5850,
    NullableValue = 65317,
},
    NullableValue = 52463,
},
            new UInt16UInt16E0M
{
    Id = 97,
    Value = 22328,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 104,
    Value = 46766,
    NullableValue = 45220,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 98,
    Value = 39080,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 110,
    Value = 59290,
    NullableValue = 29555,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 106,
    Value = 42818,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 117,
    Value = 62058,
    NullableValue = null,
},
    NullableValue = 53605,
},
            new UInt16UInt16E0M
{
    Id = 108,
    Value = 38699,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 121,
    Value = 11732,
    NullableValue = 47008,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 109,
    Value = 51210,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 129,
    Value = 28319,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 117,
    Value = 44106,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 134,
    Value = 229,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 123,
    Value = 16589,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 141,
    Value = 58315,
    NullableValue = 12054,
},
    NullableValue = 42849,
},
            new UInt16UInt16E0M
{
    Id = 131,
    Value = 30076,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 147,
    Value = 6106,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 132,
    Value = 36077,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 148,
    Value = 12,
    NullableValue = null,
},
    NullableValue = 23521,
},
            new UInt16UInt16E0M
{
    Id = 135,
    Value = 43461,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 153,
    Value = 32822,
    NullableValue = 56596,
},
    NullableValue = 20663,
},
            new UInt16UInt16E0M
{
    Id = 137,
    Value = 27873,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 154,
    Value = 42652,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 139,
    Value = 26834,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 161,
    Value = 23957,
    NullableValue = null,
},
    NullableValue = 35517,
},
            new UInt16UInt16E0M
{
    Id = 142,
    Value = 60513,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 168,
    Value = 62297,
    NullableValue = 15614,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 146,
    Value = 3310,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 173,
    Value = 2669,
    NullableValue = null,
},
    NullableValue = 9616,
},
            new UInt16UInt16E0M
{
    Id = 147,
    Value = 7855,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 182,
    Value = 64754,
    NullableValue = 49820,
},
    NullableValue = 19263,
},
            new UInt16UInt16E0M
{
    Id = 153,
    Value = 34740,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 184,
    Value = 62474,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 154,
    Value = 12054,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 186,
    Value = 16130,
    NullableValue = 38565,
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
INSERT INTO gedaqtests.uint16uint16e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt16}, 
    {mi_id:Int32},
    {mi_value:UInt16}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypeUInt16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16), 
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
                    await ((IUInt16SingleTypeUInt16)this).InsertModelDbConnectionAsync(
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
                     ((IUInt16SingleTypeUInt16)this).InsertModelDbConnection(
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
FROM gedaqtests.uint16uint16e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt16UInt16E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypeUInt16)),
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
                    var models = await ((IUInt16SingleTypeUInt16)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16UInt16E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt16SingleTypeUInt16)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16UInt16E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

