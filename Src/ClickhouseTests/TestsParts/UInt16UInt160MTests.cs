

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
    Id = 7,
    Value = 18214,
    ModelInner = new UInt16UInt160MI
{
    Id = 6,
    Value = 61828,
    NullableValue = 62770,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 16,
    Value = 29879,
    ModelInner = new UInt16UInt160MI
{
    Id = 9,
    Value = 65347,
    NullableValue = 61663,
},
    NullableValue = 24215,
},
            new UInt16UInt160M
{
    Id = 25,
    Value = 57367,
    ModelInner = new UInt16UInt160MI
{
    Id = 12,
    Value = 2310,
    NullableValue = 18446,
},
    NullableValue = 34131,
},
            new UInt16UInt160M
{
    Id = 30,
    Value = 32149,
    ModelInner = new UInt16UInt160MI
{
    Id = 20,
    Value = 30361,
    NullableValue = null,
},
    NullableValue = 59014,
},
            new UInt16UInt160M
{
    Id = 35,
    Value = 55259,
    ModelInner = new UInt16UInt160MI
{
    Id = 22,
    Value = 1144,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 43,
    Value = 1765,
    ModelInner = new UInt16UInt160MI
{
    Id = 24,
    Value = 65515,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 50,
    Value = 29034,
    ModelInner = new UInt16UInt160MI
{
    Id = 31,
    Value = 60069,
    NullableValue = null,
},
    NullableValue = 18797,
},
            new UInt16UInt160M
{
    Id = 58,
    Value = 27639,
    ModelInner = new UInt16UInt160MI
{
    Id = 37,
    Value = 50065,
    NullableValue = 27375,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 63,
    Value = 64113,
    ModelInner = new UInt16UInt160MI
{
    Id = 40,
    Value = 57565,
    NullableValue = 43806,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 69,
    Value = 20940,
    ModelInner = new UInt16UInt160MI
{
    Id = 49,
    Value = 24679,
    NullableValue = 30754,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 78,
    Value = 56001,
    ModelInner = new UInt16UInt160MI
{
    Id = 52,
    Value = 6831,
    NullableValue = null,
},
    NullableValue = 32929,
},
            new UInt16UInt160M
{
    Id = 81,
    Value = 7637,
    ModelInner = new UInt16UInt160MI
{
    Id = 60,
    Value = 60354,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 85,
    Value = 13664,
    ModelInner = new UInt16UInt160MI
{
    Id = 65,
    Value = 41827,
    NullableValue = null,
},
    NullableValue = 11609,
},
            new UInt16UInt160M
{
    Id = 91,
    Value = 22678,
    ModelInner = new UInt16UInt160MI
{
    Id = 71,
    Value = 21349,
    NullableValue = null,
},
    NullableValue = 14629,
},
            new UInt16UInt160M
{
    Id = 93,
    Value = 32218,
    ModelInner = new UInt16UInt160MI
{
    Id = 80,
    Value = 22890,
    NullableValue = 32977,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 97,
    Value = 18085,
    ModelInner = new UInt16UInt160MI
{
    Id = 89,
    Value = 46385,
    NullableValue = 24874,
},
    NullableValue = 63784,
},
            new UInt16UInt160M
{
    Id = 102,
    Value = 28707,
    ModelInner = new UInt16UInt160MI
{
    Id = 95,
    Value = 41027,
    NullableValue = 23807,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 109,
    Value = 27759,
    ModelInner = new UInt16UInt160MI
{
    Id = 103,
    Value = 58808,
    NullableValue = 49424,
},
    NullableValue = 12410,
},
            new UInt16UInt160M
{
    Id = 118,
    Value = 20684,
    ModelInner = new UInt16UInt160MI
{
    Id = 105,
    Value = 25224,
    NullableValue = 6231,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 125,
    Value = 13674,
    ModelInner = new UInt16UInt160MI
{
    Id = 110,
    Value = 60409,
    NullableValue = 22008,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 127,
    Value = 61315,
    ModelInner = new UInt16UInt160MI
{
    Id = 114,
    Value = 49486,
    NullableValue = null,
},
    NullableValue = 4513,
},
            new UInt16UInt160M
{
    Id = 136,
    Value = 57648,
    ModelInner = new UInt16UInt160MI
{
    Id = 122,
    Value = 40909,
    NullableValue = 42171,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 138,
    Value = 3379,
    ModelInner = new UInt16UInt160MI
{
    Id = 124,
    Value = 46800,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 142,
    Value = 1472,
    ModelInner = new UInt16UInt160MI
{
    Id = 133,
    Value = 62397,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 151,
    Value = 48961,
    ModelInner = new UInt16UInt160MI
{
    Id = 135,
    Value = 15811,
    NullableValue = 57882,
},
    NullableValue = 13968,
},
            new UInt16UInt160M
{
    Id = 156,
    Value = 10632,
    ModelInner = new UInt16UInt160MI
{
    Id = 139,
    Value = 39416,
    NullableValue = 31191,
},
    NullableValue = 5262,
},
            new UInt16UInt160M
{
    Id = 165,
    Value = 37537,
    ModelInner = new UInt16UInt160MI
{
    Id = 148,
    Value = 16535,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 171,
    Value = 8679,
    ModelInner = new UInt16UInt160MI
{
    Id = 149,
    Value = 62335,
    NullableValue = 23737,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 173,
    Value = 49595,
    ModelInner = new UInt16UInt160MI
{
    Id = 153,
    Value = 63521,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 174,
    Value = 6624,
    ModelInner = new UInt16UInt160MI
{
    Id = 161,
    Value = 33165,
    NullableValue = 16576,
},
    NullableValue = null,
},
            new UInt16UInt160M
{
    Id = 177,
    Value = 32135,
    ModelInner = new UInt16UInt160MI
{
    Id = 163,
    Value = 36010,
    NullableValue = 49539,
},
    NullableValue = 65323,
},
            new UInt16UInt160M
{
    Id = 181,
    Value = 42053,
    ModelInner = new UInt16UInt160MI
{
    Id = 165,
    Value = 472,
    NullableValue = null,
},
    NullableValue = 33411,
},
            new UInt16UInt160M
{
    Id = 186,
    Value = 59224,
    ModelInner = new UInt16UInt160MI
{
    Id = 174,
    Value = 37911,
    NullableValue = null,
},
    NullableValue = 60676,
},
            new UInt16UInt160M
{
    Id = 193,
    Value = 49326,
    ModelInner = new UInt16UInt160MI
{
    Id = 181,
    Value = 41749,
    NullableValue = null,
},
    NullableValue = 56779,
},
            new UInt16UInt160M
{
    Id = 202,
    Value = 30025,
    ModelInner = new UInt16UInt160MI
{
    Id = 186,
    Value = 44246,
    NullableValue = 54159,
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

