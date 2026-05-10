

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
    internal partial interface IUInt32SingleTypeUInt32
    {
    }
    
    internal partial class UInt32SingleTypeUInt32 : IUInt32SingleTypeUInt32
    {


#region TestData

        private readonly UInt32UInt320M[] _testData = new UInt32UInt320M[]
        {
            new UInt32UInt320M
{
    Id = 6,
    Value = 731992936,
    ModelInner = new UInt32UInt320MI
{
    Id = 8,
    Value = 2497426295,
    NullableValue = 2653169643,
},
    NullableValue = 3110635558,
},
            new UInt32UInt320M
{
    Id = 10,
    Value = 3523770989,
    ModelInner = new UInt32UInt320MI
{
    Id = 12,
    Value = 1990070806,
    NullableValue = null,
},
    NullableValue = 53973190,
},
            new UInt32UInt320M
{
    Id = 12,
    Value = 1667907489,
    ModelInner = new UInt32UInt320MI
{
    Id = 14,
    Value = 3126024293,
    NullableValue = 2233700528,
},
    NullableValue = 163904546,
},
            new UInt32UInt320M
{
    Id = 21,
    Value = 1680412444,
    ModelInner = new UInt32UInt320MI
{
    Id = 23,
    Value = 1955586696,
    NullableValue = 4044920267,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 26,
    Value = 3064349976,
    ModelInner = new UInt32UInt320MI
{
    Id = 25,
    Value = 3199811154,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 30,
    Value = 442602888,
    ModelInner = new UInt32UInt320MI
{
    Id = 34,
    Value = 4034421617,
    NullableValue = 1087529645,
},
    NullableValue = 1316498176,
},
            new UInt32UInt320M
{
    Id = 34,
    Value = 31228173,
    ModelInner = new UInt32UInt320MI
{
    Id = 37,
    Value = 1407652242,
    NullableValue = 3229133498,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 37,
    Value = 3307726419,
    ModelInner = new UInt32UInt320MI
{
    Id = 44,
    Value = 200213657,
    NullableValue = 1995913108,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 41,
    Value = 4187843774,
    ModelInner = new UInt32UInt320MI
{
    Id = 49,
    Value = 1466374614,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 46,
    Value = 3896702928,
    ModelInner = new UInt32UInt320MI
{
    Id = 51,
    Value = 2977725433,
    NullableValue = 2519626393,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 48,
    Value = 2129970974,
    ModelInner = new UInt32UInt320MI
{
    Id = 55,
    Value = 3866982227,
    NullableValue = 1585699668,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 53,
    Value = 45254712,
    ModelInner = new UInt32UInt320MI
{
    Id = 58,
    Value = 785516113,
    NullableValue = 1956673013,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 56,
    Value = 1800435067,
    ModelInner = new UInt32UInt320MI
{
    Id = 67,
    Value = 780708166,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 63,
    Value = 2968982887,
    ModelInner = new UInt32UInt320MI
{
    Id = 69,
    Value = 2806616751,
    NullableValue = 2034889503,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 69,
    Value = 974441132,
    ModelInner = new UInt32UInt320MI
{
    Id = 73,
    Value = 2822308479,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 76,
    Value = 825321090,
    ModelInner = new UInt32UInt320MI
{
    Id = 77,
    Value = 3470231159,
    NullableValue = 654548377,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 79,
    Value = 3337816175,
    ModelInner = new UInt32UInt320MI
{
    Id = 86,
    Value = 4285783835,
    NullableValue = 2086729283,
},
    NullableValue = 1105818738,
},
            new UInt32UInt320M
{
    Id = 82,
    Value = 1770184189,
    ModelInner = new UInt32UInt320MI
{
    Id = 90,
    Value = 3502742063,
    NullableValue = 3452850771,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 88,
    Value = 1465661745,
    ModelInner = new UInt32UInt320MI
{
    Id = 98,
    Value = 930073058,
    NullableValue = null,
},
    NullableValue = 3411683882,
},
            new UInt32UInt320M
{
    Id = 97,
    Value = 3863294432,
    ModelInner = new UInt32UInt320MI
{
    Id = 104,
    Value = 2614021401,
    NullableValue = 2307228056,
},
    NullableValue = 564805281,
},
            new UInt32UInt320M
{
    Id = 102,
    Value = 3147024652,
    ModelInner = new UInt32UInt320MI
{
    Id = 105,
    Value = 507764049,
    NullableValue = 3122316748,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 111,
    Value = 3892233907,
    ModelInner = new UInt32UInt320MI
{
    Id = 108,
    Value = 4084445097,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 112,
    Value = 2179635137,
    ModelInner = new UInt32UInt320MI
{
    Id = 111,
    Value = 2487043906,
    NullableValue = 2929063073,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 121,
    Value = 3834943950,
    ModelInner = new UInt32UInt320MI
{
    Id = 117,
    Value = 92636920,
    NullableValue = 1946967957,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 127,
    Value = 699589892,
    ModelInner = new UInt32UInt320MI
{
    Id = 120,
    Value = 2261609220,
    NullableValue = null,
},
    NullableValue = 2609802322,
},
            new UInt32UInt320M
{
    Id = 136,
    Value = 3253794274,
    ModelInner = new UInt32UInt320MI
{
    Id = 128,
    Value = 3139129647,
    NullableValue = null,
},
    NullableValue = 2967806306,
},
            new UInt32UInt320M
{
    Id = 139,
    Value = 3114322385,
    ModelInner = new UInt32UInt320MI
{
    Id = 134,
    Value = 3834197057,
    NullableValue = 1854567915,
},
    NullableValue = 3042351006,
},
            new UInt32UInt320M
{
    Id = 144,
    Value = 2198524068,
    ModelInner = new UInt32UInt320MI
{
    Id = 140,
    Value = 1332939961,
    NullableValue = 1381699319,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 146,
    Value = 41771002,
    ModelInner = new UInt32UInt320MI
{
    Id = 141,
    Value = 1083359014,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 154,
    Value = 1664025569,
    ModelInner = new UInt32UInt320MI
{
    Id = 150,
    Value = 2070314422,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 155,
    Value = 2456195704,
    ModelInner = new UInt32UInt320MI
{
    Id = 158,
    Value = 3578257445,
    NullableValue = 2848881895,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 156,
    Value = 1881552881,
    ModelInner = new UInt32UInt320MI
{
    Id = 165,
    Value = 796552343,
    NullableValue = 3588062426,
},
    NullableValue = 887260430,
},
            new UInt32UInt320M
{
    Id = 159,
    Value = 3494416527,
    ModelInner = new UInt32UInt320MI
{
    Id = 173,
    Value = 329798086,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 163,
    Value = 4209718214,
    ModelInner = new UInt32UInt320MI
{
    Id = 177,
    Value = 1448577974,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 168,
    Value = 876653959,
    ModelInner = new UInt32UInt320MI
{
    Id = 181,
    Value = 3642211908,
    NullableValue = 1114943864,
},
    NullableValue = 4214366438,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint32uint320m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt32}, 
    {mi_id:Int32},
    {mi_value:UInt32}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeUInt32)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32), 
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
                    await ((IUInt32SingleTypeUInt32)this).InsertModelDbConnectionAsync(
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
                     ((IUInt32SingleTypeUInt32)this).InsertModelDbConnection(
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
FROM gedaqtests.uint32uint320m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32UInt320M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeUInt32)),
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
                    var models = await ((IUInt32SingleTypeUInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32UInt320M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt32SingleTypeUInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32UInt320M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

