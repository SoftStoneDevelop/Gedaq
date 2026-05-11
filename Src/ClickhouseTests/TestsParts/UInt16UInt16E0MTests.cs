

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
    Id = 8,
    Value = 34611,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 3,
    Value = 36448,
    NullableValue = 27130,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 15,
    Value = 16151,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 7,
    Value = 32527,
    NullableValue = 56271,
},
    NullableValue = 39577,
},
            new UInt16UInt16E0M
{
    Id = 19,
    Value = 3439,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 13,
    Value = 60663,
    NullableValue = 13479,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 26,
    Value = 25608,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 20,
    Value = 19404,
    NullableValue = null,
},
    NullableValue = 53064,
},
            new UInt16UInt16E0M
{
    Id = 32,
    Value = 42568,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 25,
    Value = 54892,
    NullableValue = null,
},
    NullableValue = 40423,
},
            new UInt16UInt16E0M
{
    Id = 33,
    Value = 59915,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 29,
    Value = 47935,
    NullableValue = null,
},
    NullableValue = 63708,
},
            new UInt16UInt16E0M
{
    Id = 41,
    Value = 10586,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 31,
    Value = 21181,
    NullableValue = null,
},
    NullableValue = 25387,
},
            new UInt16UInt16E0M
{
    Id = 45,
    Value = 9401,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 34,
    Value = 28555,
    NullableValue = 29646,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 52,
    Value = 22957,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 35,
    Value = 38636,
    NullableValue = 39791,
},
    NullableValue = 57528,
},
            new UInt16UInt16E0M
{
    Id = 57,
    Value = 7085,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 42,
    Value = 54079,
    NullableValue = 33916,
},
    NullableValue = 5107,
},
            new UInt16UInt16E0M
{
    Id = 64,
    Value = 35134,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 49,
    Value = 22342,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 66,
    Value = 1152,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 58,
    Value = 10968,
    NullableValue = 4793,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 73,
    Value = 16862,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 67,
    Value = 21586,
    NullableValue = 126,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 78,
    Value = 1989,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 71,
    Value = 28623,
    NullableValue = null,
},
    NullableValue = 11186,
},
            new UInt16UInt16E0M
{
    Id = 83,
    Value = 14316,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 78,
    Value = 48091,
    NullableValue = null,
},
    NullableValue = 56152,
},
            new UInt16UInt16E0M
{
    Id = 86,
    Value = 34776,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 86,
    Value = 43954,
    NullableValue = 13394,
},
    NullableValue = 32817,
},
            new UInt16UInt16E0M
{
    Id = 95,
    Value = 56366,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 92,
    Value = 31534,
    NullableValue = 40607,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 96,
    Value = 46472,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 93,
    Value = 64717,
    NullableValue = 30403,
},
    NullableValue = 61141,
},
            new UInt16UInt16E0M
{
    Id = 100,
    Value = 14698,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 102,
    Value = 37803,
    NullableValue = null,
},
    NullableValue = 14370,
},
            new UInt16UInt16E0M
{
    Id = 104,
    Value = 6106,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 105,
    Value = 64403,
    NullableValue = null,
},
    NullableValue = 39597,
},
            new UInt16UInt16E0M
{
    Id = 111,
    Value = 18799,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 109,
    Value = 7059,
    NullableValue = 8749,
},
    NullableValue = 45521,
},
            new UInt16UInt16E0M
{
    Id = 114,
    Value = 63083,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 118,
    Value = 65434,
    NullableValue = 31816,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 117,
    Value = 56827,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 124,
    Value = 23134,
    NullableValue = 30898,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 122,
    Value = 56397,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 131,
    Value = 31162,
    NullableValue = 50596,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 128,
    Value = 44125,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 136,
    Value = 42337,
    NullableValue = 47437,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 135,
    Value = 22657,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 137,
    Value = 16692,
    NullableValue = 1693,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 136,
    Value = 40458,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 141,
    Value = 24304,
    NullableValue = null,
},
    NullableValue = 3422,
},
            new UInt16UInt16E0M
{
    Id = 140,
    Value = 15656,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 145,
    Value = 59930,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 143,
    Value = 33252,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 151,
    Value = 62140,
    NullableValue = 31528,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 144,
    Value = 59275,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 152,
    Value = 372,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 149,
    Value = 37958,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 154,
    Value = 48592,
    NullableValue = 41862,
},
    NullableValue = 27913,
},
            new UInt16UInt16E0M
{
    Id = 156,
    Value = 49591,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 157,
    Value = 26466,
    NullableValue = 31514,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 157,
    Value = 36518,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 166,
    Value = 32218,
    NullableValue = null,
},
    NullableValue = 59925,
},
            new UInt16UInt16E0M
{
    Id = 158,
    Value = 20694,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 173,
    Value = 53312,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 167,
    Value = 54684,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 176,
    Value = 28404,
    NullableValue = null,
},
    NullableValue = 61060,
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

