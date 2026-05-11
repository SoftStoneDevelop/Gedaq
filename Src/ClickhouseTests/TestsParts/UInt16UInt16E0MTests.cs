

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
    Value = 61498,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 9,
    Value = 28683,
    NullableValue = null,
},
    NullableValue = 3164,
},
            new UInt16UInt16E0M
{
    Id = 6,
    Value = 60838,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 17,
    Value = 61255,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 14,
    Value = 57324,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 23,
    Value = 17500,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 18,
    Value = 31210,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 25,
    Value = 64125,
    NullableValue = null,
},
    NullableValue = 1630,
},
            new UInt16UInt16E0M
{
    Id = 19,
    Value = 34172,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 34,
    Value = 4035,
    NullableValue = 11461,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 21,
    Value = 43096,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 42,
    Value = 53847,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 29,
    Value = 10886,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 50,
    Value = 27645,
    NullableValue = 44990,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 32,
    Value = 31428,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 54,
    Value = 46772,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 34,
    Value = 2392,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 55,
    Value = 49354,
    NullableValue = 15392,
},
    NullableValue = 41478,
},
            new UInt16UInt16E0M
{
    Id = 38,
    Value = 63309,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 61,
    Value = 45310,
    NullableValue = 47593,
},
    NullableValue = 34686,
},
            new UInt16UInt16E0M
{
    Id = 43,
    Value = 2754,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 70,
    Value = 6952,
    NullableValue = 62974,
},
    NullableValue = 32433,
},
            new UInt16UInt16E0M
{
    Id = 45,
    Value = 3873,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 79,
    Value = 43907,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 50,
    Value = 23876,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 86,
    Value = 6528,
    NullableValue = 31171,
},
    NullableValue = 46677,
},
            new UInt16UInt16E0M
{
    Id = 51,
    Value = 42371,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 92,
    Value = 10146,
    NullableValue = 16803,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 52,
    Value = 64673,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 96,
    Value = 22739,
    NullableValue = 10359,
},
    NullableValue = 10661,
},
            new UInt16UInt16E0M
{
    Id = 53,
    Value = 65397,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 105,
    Value = 4924,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 58,
    Value = 56908,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 107,
    Value = 38367,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 63,
    Value = 39150,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 112,
    Value = 54020,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 67,
    Value = 15675,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 113,
    Value = 53226,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 75,
    Value = 2689,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 116,
    Value = 42771,
    NullableValue = 11326,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 82,
    Value = 49415,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 124,
    Value = 58139,
    NullableValue = 63707,
},
    NullableValue = 9277,
},
            new UInt16UInt16E0M
{
    Id = 88,
    Value = 58738,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 128,
    Value = 9528,
    NullableValue = 49786,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 92,
    Value = 23520,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 132,
    Value = 61277,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 101,
    Value = 27173,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 134,
    Value = 49755,
    NullableValue = 45173,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 102,
    Value = 1979,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 136,
    Value = 2165,
    NullableValue = 21180,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 104,
    Value = 26978,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 139,
    Value = 36142,
    NullableValue = 24352,
},
    NullableValue = 8760,
},
            new UInt16UInt16E0M
{
    Id = 105,
    Value = 8560,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 142,
    Value = 7872,
    NullableValue = 62,
},
    NullableValue = 25465,
},
            new UInt16UInt16E0M
{
    Id = 106,
    Value = 26487,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 147,
    Value = 28849,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 107,
    Value = 53734,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 153,
    Value = 60591,
    NullableValue = 52162,
},
    NullableValue = 21184,
},
            new UInt16UInt16E0M
{
    Id = 114,
    Value = 56781,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 156,
    Value = 22123,
    NullableValue = null,
},
    NullableValue = 45407,
},
            new UInt16UInt16E0M
{
    Id = 122,
    Value = 37784,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 164,
    Value = 23795,
    NullableValue = null,
},
    NullableValue = 57114,
},
            new UInt16UInt16E0M
{
    Id = 124,
    Value = 10783,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 166,
    Value = 6365,
    NullableValue = 27561,
},
    NullableValue = 29376,
},
            new UInt16UInt16E0M
{
    Id = 126,
    Value = 25311,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 170,
    Value = 34640,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 132,
    Value = 36740,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 179,
    Value = 225,
    NullableValue = 12404,
},
    NullableValue = 57943,
},
            new UInt16UInt16E0M
{
    Id = 135,
    Value = 43980,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 183,
    Value = 25349,
    NullableValue = 57192,
},
    NullableValue = 14923,
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

