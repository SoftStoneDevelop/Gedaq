

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
    Id = 9,
    Value = 23215,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 4,
    Value = 15055,
    NullableValue = null,
},
    NullableValue = 59259,
},
            new UInt16UInt16E0M
{
    Id = 13,
    Value = 6450,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 11,
    Value = 17237,
    NullableValue = 33927,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 16,
    Value = 13084,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 18,
    Value = 42739,
    NullableValue = null,
},
    NullableValue = 29309,
},
            new UInt16UInt16E0M
{
    Id = 19,
    Value = 44463,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 27,
    Value = 20436,
    NullableValue = 59876,
},
    NullableValue = 36367,
},
            new UInt16UInt16E0M
{
    Id = 27,
    Value = 38725,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 33,
    Value = 52674,
    NullableValue = 7413,
},
    NullableValue = 7854,
},
            new UInt16UInt16E0M
{
    Id = 31,
    Value = 16853,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 40,
    Value = 53517,
    NullableValue = 5361,
},
    NullableValue = 8483,
},
            new UInt16UInt16E0M
{
    Id = 33,
    Value = 40922,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 46,
    Value = 15827,
    NullableValue = 16932,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 40,
    Value = 37006,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 48,
    Value = 49441,
    NullableValue = 13305,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 41,
    Value = 24577,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 50,
    Value = 41289,
    NullableValue = 25468,
},
    NullableValue = 43647,
},
            new UInt16UInt16E0M
{
    Id = 44,
    Value = 55488,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 55,
    Value = 35139,
    NullableValue = 48935,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 50,
    Value = 8896,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 64,
    Value = 50070,
    NullableValue = null,
},
    NullableValue = 59056,
},
            new UInt16UInt16E0M
{
    Id = 58,
    Value = 51585,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 67,
    Value = 29117,
    NullableValue = null,
},
    NullableValue = 39545,
},
            new UInt16UInt16E0M
{
    Id = 65,
    Value = 59430,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 73,
    Value = 6950,
    NullableValue = 39202,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 74,
    Value = 26129,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 80,
    Value = 15412,
    NullableValue = 14570,
},
    NullableValue = 54563,
},
            new UInt16UInt16E0M
{
    Id = 75,
    Value = 52579,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 81,
    Value = 11728,
    NullableValue = 52764,
},
    NullableValue = 4613,
},
            new UInt16UInt16E0M
{
    Id = 78,
    Value = 64292,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 89,
    Value = 56195,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 87,
    Value = 15781,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 92,
    Value = 17309,
    NullableValue = null,
},
    NullableValue = 4453,
},
            new UInt16UInt16E0M
{
    Id = 92,
    Value = 51728,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 99,
    Value = 22287,
    NullableValue = 47146,
},
    NullableValue = 34241,
},
            new UInt16UInt16E0M
{
    Id = 94,
    Value = 33280,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 107,
    Value = 38015,
    NullableValue = 36320,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 101,
    Value = 16646,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 108,
    Value = 4949,
    NullableValue = 60945,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 108,
    Value = 10859,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 117,
    Value = 13666,
    NullableValue = null,
},
    NullableValue = 4644,
},
            new UInt16UInt16E0M
{
    Id = 111,
    Value = 40999,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 119,
    Value = 52177,
    NullableValue = 47296,
},
    NullableValue = 23587,
},
            new UInt16UInt16E0M
{
    Id = 117,
    Value = 29281,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 127,
    Value = 1912,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 126,
    Value = 55032,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 130,
    Value = 36893,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 133,
    Value = 15378,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 139,
    Value = 4603,
    NullableValue = 6683,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 134,
    Value = 6503,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 142,
    Value = 52552,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 138,
    Value = 44651,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 149,
    Value = 24434,
    NullableValue = 54777,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 139,
    Value = 898,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 155,
    Value = 4029,
    NullableValue = 51118,
},
    NullableValue = 61085,
},
            new UInt16UInt16E0M
{
    Id = 143,
    Value = 16915,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 163,
    Value = 28011,
    NullableValue = 40387,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 151,
    Value = 49400,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 169,
    Value = 62067,
    NullableValue = 9536,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 156,
    Value = 54870,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 173,
    Value = 14801,
    NullableValue = null,
},
    NullableValue = 34105,
},
            new UInt16UInt16E0M
{
    Id = 157,
    Value = 55307,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 174,
    Value = 21716,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 161,
    Value = 26912,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 179,
    Value = 55712,
    NullableValue = 63475,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 170,
    Value = 58879,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 188,
    Value = 26918,
    NullableValue = 11063,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 178,
    Value = 17191,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 194,
    Value = 10201,
    NullableValue = 28916,
},
    NullableValue = 8649,
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

