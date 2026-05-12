

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
    Id = 1,
    Value = 24434,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 4,
    Value = 27286,
    NullableValue = 59865,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 8,
    Value = 58721,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 13,
    Value = 28318,
    NullableValue = null,
},
    NullableValue = 57706,
},
            new UInt16UInt16E0M
{
    Id = 11,
    Value = 52087,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 20,
    Value = 28592,
    NullableValue = 48496,
},
    NullableValue = 29493,
},
            new UInt16UInt16E0M
{
    Id = 19,
    Value = 45585,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 25,
    Value = 22544,
    NullableValue = 50440,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 20,
    Value = 49163,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 29,
    Value = 58102,
    NullableValue = 19303,
},
    NullableValue = 43913,
},
            new UInt16UInt16E0M
{
    Id = 24,
    Value = 44405,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 34,
    Value = 5237,
    NullableValue = null,
},
    NullableValue = 8319,
},
            new UInt16UInt16E0M
{
    Id = 26,
    Value = 14904,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 41,
    Value = 5779,
    NullableValue = 24536,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 27,
    Value = 35264,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 43,
    Value = 51988,
    NullableValue = 48765,
},
    NullableValue = 36248,
},
            new UInt16UInt16E0M
{
    Id = 29,
    Value = 33326,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 48,
    Value = 57974,
    NullableValue = 1629,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 38,
    Value = 34416,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 53,
    Value = 54021,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 43,
    Value = 46442,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 61,
    Value = 18925,
    NullableValue = 23820,
},
    NullableValue = 4752,
},
            new UInt16UInt16E0M
{
    Id = 46,
    Value = 42711,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 63,
    Value = 59558,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 51,
    Value = 39538,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 67,
    Value = 28157,
    NullableValue = 36086,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 58,
    Value = 61078,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 76,
    Value = 54031,
    NullableValue = 28175,
},
    NullableValue = 38276,
},
            new UInt16UInt16E0M
{
    Id = 66,
    Value = 33720,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 80,
    Value = 33812,
    NullableValue = null,
},
    NullableValue = 5092,
},
            new UInt16UInt16E0M
{
    Id = 72,
    Value = 25672,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 81,
    Value = 34071,
    NullableValue = 39487,
},
    NullableValue = 43279,
},
            new UInt16UInt16E0M
{
    Id = 73,
    Value = 26069,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 89,
    Value = 37334,
    NullableValue = null,
},
    NullableValue = 12630,
},
            new UInt16UInt16E0M
{
    Id = 80,
    Value = 19483,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 94,
    Value = 40868,
    NullableValue = 44030,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 87,
    Value = 61999,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 102,
    Value = 5371,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 88,
    Value = 7199,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 108,
    Value = 10958,
    NullableValue = null,
},
    NullableValue = 17125,
},
            new UInt16UInt16E0M
{
    Id = 96,
    Value = 64060,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 109,
    Value = 30441,
    NullableValue = 21961,
},
    NullableValue = 58805,
},
            new UInt16UInt16E0M
{
    Id = 103,
    Value = 50285,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 118,
    Value = 62974,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 111,
    Value = 52466,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 119,
    Value = 30907,
    NullableValue = null,
},
    NullableValue = 48356,
},
            new UInt16UInt16E0M
{
    Id = 113,
    Value = 48992,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 125,
    Value = 64350,
    NullableValue = null,
},
    NullableValue = 24948,
},
            new UInt16UInt16E0M
{
    Id = 121,
    Value = 61227,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 130,
    Value = 43023,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 123,
    Value = 22109,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 132,
    Value = 22276,
    NullableValue = 5013,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 127,
    Value = 11035,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 138,
    Value = 24794,
    NullableValue = 60927,
},
    NullableValue = 61919,
},
            new UInt16UInt16E0M
{
    Id = 130,
    Value = 56574,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 144,
    Value = 23389,
    NullableValue = null,
},
    NullableValue = 34337,
},
            new UInt16UInt16E0M
{
    Id = 139,
    Value = 53890,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 151,
    Value = 8429,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 148,
    Value = 59860,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 156,
    Value = 18538,
    NullableValue = null,
},
    NullableValue = 6616,
},
            new UInt16UInt16E0M
{
    Id = 154,
    Value = 38831,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 164,
    Value = 17929,
    NullableValue = null,
},
    NullableValue = 29780,
},
            new UInt16UInt16E0M
{
    Id = 160,
    Value = 52189,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 171,
    Value = 19962,
    NullableValue = 10567,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 164,
    Value = 63339,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 179,
    Value = 22937,
    NullableValue = 13116,
},
    NullableValue = 65129,
},
            new UInt16UInt16E0M
{
    Id = 169,
    Value = 55067,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 182,
    Value = 51092,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 173,
    Value = 7750,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 188,
    Value = 45270,
    NullableValue = 60116,
},
    NullableValue = 51350,
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

