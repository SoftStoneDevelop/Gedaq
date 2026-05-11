

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
    internal partial interface IInt16SingleTypeInt16
    {
    }
    
    internal partial class Int16SingleTypeInt16 : IInt16SingleTypeInt16
    {


#region TestData

        private readonly Int16Int16E0M[] _testData = new Int16Int16E0M[]
        {
            new Int16Int16E0M
{
    Id = 2,
    Value = 2013,
    ModelInner = new Int16Int16E0MI
{
    Id = 1,
    Value = 827,
    NullableValue = null,
},
    NullableValue = 17758,
},
            new Int16Int16E0M
{
    Id = 3,
    Value = 22922,
    ModelInner = new Int16Int16E0MI
{
    Id = 5,
    Value = 3756,
    NullableValue = 19928,
},
    NullableValue = 11756,
},
            new Int16Int16E0M
{
    Id = 5,
    Value = 840,
    ModelInner = new Int16Int16E0MI
{
    Id = 9,
    Value = 28600,
    NullableValue = null,
},
    NullableValue = 26837,
},
            new Int16Int16E0M
{
    Id = 12,
    Value = 29522,
    ModelInner = new Int16Int16E0MI
{
    Id = 17,
    Value = 29358,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 13,
    Value = 15936,
    ModelInner = new Int16Int16E0MI
{
    Id = 21,
    Value = 11390,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 21,
    Value = 14427,
    ModelInner = new Int16Int16E0MI
{
    Id = 22,
    Value = 6352,
    NullableValue = null,
},
    NullableValue = 26915,
},
            new Int16Int16E0M
{
    Id = 28,
    Value = 24179,
    ModelInner = new Int16Int16E0MI
{
    Id = 26,
    Value = 31410,
    NullableValue = null,
},
    NullableValue = 22868,
},
            new Int16Int16E0M
{
    Id = 34,
    Value = 26070,
    ModelInner = new Int16Int16E0MI
{
    Id = 33,
    Value = 12007,
    NullableValue = 15510,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 36,
    Value = 28952,
    ModelInner = new Int16Int16E0MI
{
    Id = 34,
    Value = 6752,
    NullableValue = 31489,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 43,
    Value = 25658,
    ModelInner = new Int16Int16E0MI
{
    Id = 43,
    Value = 6709,
    NullableValue = 20439,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 51,
    Value = 11442,
    ModelInner = new Int16Int16E0MI
{
    Id = 49,
    Value = 24106,
    NullableValue = 16183,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 58,
    Value = 24567,
    ModelInner = new Int16Int16E0MI
{
    Id = 52,
    Value = 28265,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 62,
    Value = 20226,
    ModelInner = new Int16Int16E0MI
{
    Id = 53,
    Value = 2331,
    NullableValue = null,
},
    NullableValue = 18466,
},
            new Int16Int16E0M
{
    Id = 63,
    Value = 31215,
    ModelInner = new Int16Int16E0MI
{
    Id = 59,
    Value = 25049,
    NullableValue = null,
},
    NullableValue = 6769,
},
            new Int16Int16E0M
{
    Id = 66,
    Value = 17368,
    ModelInner = new Int16Int16E0MI
{
    Id = 61,
    Value = 32447,
    NullableValue = 13950,
},
    NullableValue = 27535,
},
            new Int16Int16E0M
{
    Id = 75,
    Value = 24622,
    ModelInner = new Int16Int16E0MI
{
    Id = 63,
    Value = 10180,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 79,
    Value = 16496,
    ModelInner = new Int16Int16E0MI
{
    Id = 65,
    Value = 22407,
    NullableValue = 22032,
},
    NullableValue = 1672,
},
            new Int16Int16E0M
{
    Id = 88,
    Value = 30244,
    ModelInner = new Int16Int16E0MI
{
    Id = 69,
    Value = 17068,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 95,
    Value = 3723,
    ModelInner = new Int16Int16E0MI
{
    Id = 70,
    Value = 5912,
    NullableValue = 19407,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 97,
    Value = 25694,
    ModelInner = new Int16Int16E0MI
{
    Id = 77,
    Value = 3803,
    NullableValue = 30618,
},
    NullableValue = 26882,
},
            new Int16Int16E0M
{
    Id = 98,
    Value = 1402,
    ModelInner = new Int16Int16E0MI
{
    Id = 85,
    Value = 29871,
    NullableValue = null,
},
    NullableValue = 17728,
},
            new Int16Int16E0M
{
    Id = 104,
    Value = 18616,
    ModelInner = new Int16Int16E0MI
{
    Id = 91,
    Value = 20366,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 108,
    Value = 16516,
    ModelInner = new Int16Int16E0MI
{
    Id = 96,
    Value = 18430,
    NullableValue = 27748,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 110,
    Value = 8742,
    ModelInner = new Int16Int16E0MI
{
    Id = 99,
    Value = 9406,
    NullableValue = 10310,
},
    NullableValue = 12408,
},
            new Int16Int16E0M
{
    Id = 116,
    Value = 5197,
    ModelInner = new Int16Int16E0MI
{
    Id = 108,
    Value = 15139,
    NullableValue = null,
},
    NullableValue = 29154,
},
            new Int16Int16E0M
{
    Id = 125,
    Value = 18902,
    ModelInner = new Int16Int16E0MI
{
    Id = 109,
    Value = 23816,
    NullableValue = null,
},
    NullableValue = 15554,
},
            new Int16Int16E0M
{
    Id = 131,
    Value = 12644,
    ModelInner = new Int16Int16E0MI
{
    Id = 113,
    Value = 8397,
    NullableValue = null,
},
    NullableValue = 19782,
},
            new Int16Int16E0M
{
    Id = 140,
    Value = 1688,
    ModelInner = new Int16Int16E0MI
{
    Id = 117,
    Value = 5163,
    NullableValue = null,
},
    NullableValue = 13137,
},
            new Int16Int16E0M
{
    Id = 142,
    Value = 13617,
    ModelInner = new Int16Int16E0MI
{
    Id = 125,
    Value = 8522,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 146,
    Value = 18035,
    ModelInner = new Int16Int16E0MI
{
    Id = 129,
    Value = 32664,
    NullableValue = 28631,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 149,
    Value = 9136,
    ModelInner = new Int16Int16E0MI
{
    Id = 132,
    Value = 29645,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 158,
    Value = 4464,
    ModelInner = new Int16Int16E0MI
{
    Id = 138,
    Value = 11634,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 162,
    Value = 11029,
    ModelInner = new Int16Int16E0MI
{
    Id = 144,
    Value = 9063,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 170,
    Value = 6908,
    ModelInner = new Int16Int16E0MI
{
    Id = 146,
    Value = 8745,
    NullableValue = 25943,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 175,
    Value = 12682,
    ModelInner = new Int16Int16E0MI
{
    Id = 152,
    Value = 19653,
    NullableValue = null,
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
INSERT INTO gedaqtests.int16int16e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Int16}, 
    {mi_id:Int32},
    {mi_value:Int16}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypeInt16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
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
                    await ((IInt16SingleTypeInt16)this).InsertModelDbConnectionAsync(
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
                     ((IInt16SingleTypeInt16)this).InsertModelDbConnection(
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
FROM gedaqtests.int16int16e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int16Int16E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypeInt16)),
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
                    var models = await ((IInt16SingleTypeInt16)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16Int16E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt16SingleTypeInt16)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16Int16E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

