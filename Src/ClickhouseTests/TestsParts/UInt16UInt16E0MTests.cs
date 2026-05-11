

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
    Id = 3,
    Value = 63885,
    ModelInner = new UInt16UInt160MI
{
    Id = 9,
    Value = 60293,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 5,
    Value = 2142,
    ModelInner = new UInt16UInt160MI
{
    Id = 16,
    Value = 18753,
    NullableValue = null,
},
    NullableValue = 32341,
},
            new UInt16UInt16E0M
{
    Id = 7,
    Value = 48828,
    ModelInner = new UInt16UInt160MI
{
    Id = 24,
    Value = 28208,
    NullableValue = 39566,
},
    NullableValue = 31273,
},
            new UInt16UInt16E0M
{
    Id = 14,
    Value = 36127,
    ModelInner = new UInt16UInt160MI
{
    Id = 28,
    Value = 29745,
    NullableValue = 57367,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 23,
    Value = 21181,
    ModelInner = new UInt16UInt160MI
{
    Id = 36,
    Value = 17460,
    NullableValue = null,
},
    NullableValue = 61133,
},
            new UInt16UInt16E0M
{
    Id = 32,
    Value = 59227,
    ModelInner = new UInt16UInt160MI
{
    Id = 40,
    Value = 2669,
    NullableValue = 46089,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 40,
    Value = 2689,
    ModelInner = new UInt16UInt160MI
{
    Id = 48,
    Value = 11663,
    NullableValue = null,
},
    NullableValue = 19801,
},
            new UInt16UInt16E0M
{
    Id = 44,
    Value = 54047,
    ModelInner = new UInt16UInt160MI
{
    Id = 56,
    Value = 12291,
    NullableValue = 27520,
},
    NullableValue = 52688,
},
            new UInt16UInt16E0M
{
    Id = 47,
    Value = 1077,
    ModelInner = new UInt16UInt160MI
{
    Id = 64,
    Value = 50780,
    NullableValue = 32438,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 55,
    Value = 11584,
    ModelInner = new UInt16UInt160MI
{
    Id = 72,
    Value = 29127,
    NullableValue = 34921,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 58,
    Value = 11809,
    ModelInner = new UInt16UInt160MI
{
    Id = 78,
    Value = 56957,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 65,
    Value = 59103,
    ModelInner = new UInt16UInt160MI
{
    Id = 86,
    Value = 17281,
    NullableValue = 50155,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 72,
    Value = 61098,
    ModelInner = new UInt16UInt160MI
{
    Id = 92,
    Value = 10295,
    NullableValue = null,
},
    NullableValue = 29551,
},
            new UInt16UInt16E0M
{
    Id = 80,
    Value = 22902,
    ModelInner = new UInt16UInt160MI
{
    Id = 98,
    Value = 53648,
    NullableValue = null,
},
    NullableValue = 58176,
},
            new UInt16UInt16E0M
{
    Id = 86,
    Value = 59895,
    ModelInner = new UInt16UInt160MI
{
    Id = 105,
    Value = 29742,
    NullableValue = 11930,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 93,
    Value = 55246,
    ModelInner = new UInt16UInt160MI
{
    Id = 112,
    Value = 11681,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 99,
    Value = 22472,
    ModelInner = new UInt16UInt160MI
{
    Id = 117,
    Value = 25137,
    NullableValue = 12441,
},
    NullableValue = 6710,
},
            new UInt16UInt16E0M
{
    Id = 107,
    Value = 55790,
    ModelInner = new UInt16UInt160MI
{
    Id = 125,
    Value = 61623,
    NullableValue = 64886,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 109,
    Value = 61062,
    ModelInner = new UInt16UInt160MI
{
    Id = 128,
    Value = 55444,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 117,
    Value = 14190,
    ModelInner = new UInt16UInt160MI
{
    Id = 131,
    Value = 44533,
    NullableValue = 61985,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 124,
    Value = 64300,
    ModelInner = new UInt16UInt160MI
{
    Id = 140,
    Value = 24284,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 129,
    Value = 38901,
    ModelInner = new UInt16UInt160MI
{
    Id = 141,
    Value = 23497,
    NullableValue = 40219,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 133,
    Value = 50473,
    ModelInner = new UInt16UInt160MI
{
    Id = 146,
    Value = 49332,
    NullableValue = 7870,
},
    NullableValue = 19436,
},
            new UInt16UInt16E0M
{
    Id = 134,
    Value = 57151,
    ModelInner = new UInt16UInt160MI
{
    Id = 150,
    Value = 5459,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 141,
    Value = 16375,
    ModelInner = new UInt16UInt160MI
{
    Id = 154,
    Value = 61277,
    NullableValue = 41016,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 148,
    Value = 20900,
    ModelInner = new UInt16UInt160MI
{
    Id = 163,
    Value = 9855,
    NullableValue = 26175,
},
    NullableValue = 29850,
},
            new UInt16UInt16E0M
{
    Id = 153,
    Value = 36882,
    ModelInner = new UInt16UInt160MI
{
    Id = 171,
    Value = 38659,
    NullableValue = 50170,
},
    NullableValue = 17018,
},
            new UInt16UInt16E0M
{
    Id = 162,
    Value = 58594,
    ModelInner = new UInt16UInt160MI
{
    Id = 174,
    Value = 63837,
    NullableValue = 53235,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 165,
    Value = 2194,
    ModelInner = new UInt16UInt160MI
{
    Id = 181,
    Value = 12571,
    NullableValue = null,
},
    NullableValue = 57666,
},
            new UInt16UInt16E0M
{
    Id = 166,
    Value = 48525,
    ModelInner = new UInt16UInt160MI
{
    Id = 189,
    Value = 55020,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 169,
    Value = 56212,
    ModelInner = new UInt16UInt160MI
{
    Id = 196,
    Value = 42342,
    NullableValue = 51004,
},
    NullableValue = 9631,
},
            new UInt16UInt16E0M
{
    Id = 171,
    Value = 4128,
    ModelInner = new UInt16UInt160MI
{
    Id = 199,
    Value = 5715,
    NullableValue = null,
},
    NullableValue = 40745,
},
            new UInt16UInt16E0M
{
    Id = 172,
    Value = 25934,
    ModelInner = new UInt16UInt160MI
{
    Id = 208,
    Value = 2427,
    NullableValue = null,
},
    NullableValue = 63421,
},
            new UInt16UInt16E0M
{
    Id = 179,
    Value = 7915,
    ModelInner = new UInt16UInt160MI
{
    Id = 209,
    Value = 34949,
    NullableValue = 34077,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 186,
    Value = 22027,
    ModelInner = new UInt16UInt160MI
{
    Id = 218,
    Value = 34229,
    NullableValue = 9977,
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

