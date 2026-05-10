

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

        private readonly UInt16UInt160M[] _testData = new UInt16UInt160M[]
        {
            new UInt16UInt160M
{
    Id = 1,
    Value = 61363,
    ModelInner = new UInt16UInt160MI
{
    Id = 1,
    Value = 61169,
    NullableValue = null,
},
    NullableValue = 40744,
},
            new UInt16UInt160M
{
    Id = 9,
    Value = 36850,
    ModelInner = new UInt16UInt160MI
{
    Id = 9,
    Value = 63798,
    NullableValue = null,
},
    NullableValue = 3832,
},
            new UInt16UInt160M
{
    Id = 18,
    Value = 3855,
    ModelInner = new UInt16UInt160MI
{
    Id = 14,
    Value = 31572,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 19,
    Value = 15044,
    ModelInner = new UInt16UInt160MI
{
    Id = 17,
    Value = 6139,
    NullableValue = 3087,
},
    NullableValue = 13216,
},
            new UInt16UInt160M
{
    Id = 27,
    Value = 44067,
    ModelInner = new UInt16UInt160MI
{
    Id = 22,
    Value = 10568,
    NullableValue = 26176,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 35,
    Value = 2859,
    ModelInner = new UInt16UInt160MI
{
    Id = 26,
    Value = 30056,
    NullableValue = null,
},
    NullableValue = 64417,
},
            new UInt16UInt160M
{
    Id = 43,
    Value = 1927,
    ModelInner = new UInt16UInt160MI
{
    Id = 29,
    Value = 55223,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 45,
    Value = 59987,
    ModelInner = new UInt16UInt160MI
{
    Id = 34,
    Value = 17582,
    NullableValue = null,
},
    NullableValue = 42542,
},
            new UInt16UInt160M
{
    Id = 48,
    Value = 54879,
    ModelInner = new UInt16UInt160MI
{
    Id = 43,
    Value = 41564,
    NullableValue = null,
},
    NullableValue = 53382,
},
            new UInt16UInt160M
{
    Id = 52,
    Value = 56189,
    ModelInner = new UInt16UInt160MI
{
    Id = 47,
    Value = 35784,
    NullableValue = 10122,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 61,
    Value = 14559,
    ModelInner = new UInt16UInt160MI
{
    Id = 52,
    Value = 22315,
    NullableValue = null,
},
    NullableValue = 19146,
},
            new UInt16UInt160M
{
    Id = 64,
    Value = 4277,
    ModelInner = new UInt16UInt160MI
{
    Id = 57,
    Value = 42182,
    NullableValue = null,
},
    NullableValue = 39168,
},
            new UInt16UInt160M
{
    Id = 66,
    Value = 65029,
    ModelInner = new UInt16UInt160MI
{
    Id = 66,
    Value = 24729,
    NullableValue = 65021,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 67,
    Value = 44225,
    ModelInner = new UInt16UInt160MI
{
    Id = 73,
    Value = 4449,
    NullableValue = 36561,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 75,
    Value = 36346,
    ModelInner = new UInt16UInt160MI
{
    Id = 79,
    Value = 34301,
    NullableValue = null,
},
    NullableValue = 56917,
},
            new UInt16UInt160M
{
    Id = 76,
    Value = 49438,
    ModelInner = new UInt16UInt160MI
{
    Id = 86,
    Value = 61129,
    NullableValue = null,
},
    NullableValue = 51661,
},
            new UInt16UInt160M
{
    Id = 83,
    Value = 62656,
    ModelInner = new UInt16UInt160MI
{
    Id = 93,
    Value = 34955,
    NullableValue = 21331,
},
    NullableValue = 14778,
},
            new UInt16UInt160M
{
    Id = 86,
    Value = 42285,
    ModelInner = new UInt16UInt160MI
{
    Id = 102,
    Value = 3773,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 91,
    Value = 40104,
    ModelInner = new UInt16UInt160MI
{
    Id = 106,
    Value = 58488,
    NullableValue = null,
},
    NullableValue = 5403,
},
            new UInt16UInt160M
{
    Id = 98,
    Value = 649,
    ModelInner = new UInt16UInt160MI
{
    Id = 112,
    Value = 50165,
    NullableValue = null,
},
    NullableValue = 7542,
},
            new UInt16UInt160M
{
    Id = 105,
    Value = 53952,
    ModelInner = new UInt16UInt160MI
{
    Id = 119,
    Value = 47469,
    NullableValue = 47337,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 113,
    Value = 4246,
    ModelInner = new UInt16UInt160MI
{
    Id = 124,
    Value = 45767,
    NullableValue = 44868,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 114,
    Value = 32932,
    ModelInner = new UInt16UInt160MI
{
    Id = 126,
    Value = 48409,
    NullableValue = 3467,
},
    NullableValue = 34031,
},
            new UInt16UInt160M
{
    Id = 123,
    Value = 14630,
    ModelInner = new UInt16UInt160MI
{
    Id = 129,
    Value = 36227,
    NullableValue = 28514,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 132,
    Value = 49840,
    ModelInner = new UInt16UInt160MI
{
    Id = 134,
    Value = 27240,
    NullableValue = null,
},
    NullableValue = 22486,
},
            new UInt16UInt160M
{
    Id = 134,
    Value = 44616,
    ModelInner = new UInt16UInt160MI
{
    Id = 142,
    Value = 36465,
    NullableValue = null,
},
    NullableValue = 52133,
},
            new UInt16UInt160M
{
    Id = 137,
    Value = 38142,
    ModelInner = new UInt16UInt160MI
{
    Id = 146,
    Value = 7439,
    NullableValue = 22221,
},
    NullableValue = 3085,
},
            new UInt16UInt160M
{
    Id = 145,
    Value = 43476,
    ModelInner = new UInt16UInt160MI
{
    Id = 148,
    Value = 64003,
    NullableValue = 22387,
},
    NullableValue = 42678,
},
            new UInt16UInt160M
{
    Id = 152,
    Value = 17243,
    ModelInner = new UInt16UInt160MI
{
    Id = 152,
    Value = 62542,
    NullableValue = 12965,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 158,
    Value = 44418,
    ModelInner = new UInt16UInt160MI
{
    Id = 155,
    Value = 49822,
    NullableValue = 54345,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 161,
    Value = 53724,
    ModelInner = new UInt16UInt160MI
{
    Id = 157,
    Value = 3137,
    NullableValue = null,
},
    NullableValue = 8284,
},
            new UInt16UInt160M
{
    Id = 165,
    Value = 37735,
    ModelInner = new UInt16UInt160MI
{
    Id = 161,
    Value = 39653,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 167,
    Value = 22909,
    ModelInner = new UInt16UInt160MI
{
    Id = 168,
    Value = 6645,
    NullableValue = null,
},
    NullableValue = 3040,
},
            new UInt16UInt160M
{
    Id = 174,
    Value = 62590,
    ModelInner = new UInt16UInt160MI
{
    Id = 170,
    Value = 22735,
    NullableValue = 19692,
},
    NullableValue = 40180,
},
            new UInt16UInt160M
{
    Id = 177,
    Value = 1161,
    ModelInner = new UInt16UInt160MI
{
    Id = 177,
    Value = 65294,
    NullableValue = null,
},
    NullableValue = 59811,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint16uint160m(
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
FROM gedaqtests.uint16uint160m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt16UInt160M)],
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
                    UInt16UInt160M.AssertModel(models[0],_testData[i], false);
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
                    UInt16UInt160M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

