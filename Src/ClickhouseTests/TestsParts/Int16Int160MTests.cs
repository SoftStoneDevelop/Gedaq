

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

        private readonly Int16Int160M[] _testData = new Int16Int160M[]
        {
            new Int16Int160M
{
    Id = 9,
    Value = 30373,
    ModelInner = new Int16Int160MI
{
    Id = 4,
    Value = 18029,
    NullableValue = 22079,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 15,
    Value = 12064,
    ModelInner = new Int16Int160MI
{
    Id = 8,
    Value = 12597,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 18,
    Value = 7457,
    ModelInner = new Int16Int160MI
{
    Id = 10,
    Value = 13369,
    NullableValue = 17028,
},
    NullableValue = 9323,
},
            new Int16Int160M
{
    Id = 23,
    Value = 25562,
    ModelInner = new Int16Int160MI
{
    Id = 11,
    Value = 20856,
    NullableValue = 31580,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 26,
    Value = 1747,
    ModelInner = new Int16Int160MI
{
    Id = 18,
    Value = 16824,
    NullableValue = null,
},
    NullableValue = 30326,
},
            new Int16Int160M
{
    Id = 28,
    Value = 192,
    ModelInner = new Int16Int160MI
{
    Id = 21,
    Value = 174,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 34,
    Value = 24158,
    ModelInner = new Int16Int160MI
{
    Id = 26,
    Value = 19532,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 40,
    Value = 7541,
    ModelInner = new Int16Int160MI
{
    Id = 28,
    Value = 22956,
    NullableValue = 22182,
},
    NullableValue = 1089,
},
            new Int16Int160M
{
    Id = 41,
    Value = 8557,
    ModelInner = new Int16Int160MI
{
    Id = 35,
    Value = 20138,
    NullableValue = 27072,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 45,
    Value = 23224,
    ModelInner = new Int16Int160MI
{
    Id = 42,
    Value = 17385,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 48,
    Value = 1507,
    ModelInner = new Int16Int160MI
{
    Id = 49,
    Value = 19225,
    NullableValue = null,
},
    NullableValue = 6397,
},
            new Int16Int160M
{
    Id = 51,
    Value = 14117,
    ModelInner = new Int16Int160MI
{
    Id = 55,
    Value = 24588,
    NullableValue = null,
},
    NullableValue = 8955,
},
            new Int16Int160M
{
    Id = 52,
    Value = 29091,
    ModelInner = new Int16Int160MI
{
    Id = 59,
    Value = 13653,
    NullableValue = null,
},
    NullableValue = 20295,
},
            new Int16Int160M
{
    Id = 53,
    Value = 32720,
    ModelInner = new Int16Int160MI
{
    Id = 63,
    Value = 29298,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 61,
    Value = 29373,
    ModelInner = new Int16Int160MI
{
    Id = 71,
    Value = 32285,
    NullableValue = 18109,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 69,
    Value = 12167,
    ModelInner = new Int16Int160MI
{
    Id = 72,
    Value = 27720,
    NullableValue = 9173,
},
    NullableValue = 3139,
},
            new Int16Int160M
{
    Id = 70,
    Value = 15004,
    ModelInner = new Int16Int160MI
{
    Id = 74,
    Value = 13420,
    NullableValue = 6055,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 79,
    Value = 15236,
    ModelInner = new Int16Int160MI
{
    Id = 77,
    Value = 10605,
    NullableValue = 24184,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 84,
    Value = 7735,
    ModelInner = new Int16Int160MI
{
    Id = 83,
    Value = 8372,
    NullableValue = null,
},
    NullableValue = 28116,
},
            new Int16Int160M
{
    Id = 85,
    Value = 26346,
    ModelInner = new Int16Int160MI
{
    Id = 84,
    Value = 23213,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 94,
    Value = 8890,
    ModelInner = new Int16Int160MI
{
    Id = 89,
    Value = 3703,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 99,
    Value = 5147,
    ModelInner = new Int16Int160MI
{
    Id = 98,
    Value = 7712,
    NullableValue = 13917,
},
    NullableValue = 31153,
},
            new Int16Int160M
{
    Id = 107,
    Value = 11488,
    ModelInner = new Int16Int160MI
{
    Id = 107,
    Value = 13015,
    NullableValue = null,
},
    NullableValue = 2191,
},
            new Int16Int160M
{
    Id = 110,
    Value = 30336,
    ModelInner = new Int16Int160MI
{
    Id = 114,
    Value = 2531,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 112,
    Value = 24894,
    ModelInner = new Int16Int160MI
{
    Id = 121,
    Value = 20889,
    NullableValue = 14939,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 120,
    Value = 7456,
    ModelInner = new Int16Int160MI
{
    Id = 124,
    Value = 14374,
    NullableValue = null,
},
    NullableValue = 18975,
},
            new Int16Int160M
{
    Id = 121,
    Value = 28969,
    ModelInner = new Int16Int160MI
{
    Id = 125,
    Value = 7900,
    NullableValue = null,
},
    NullableValue = 31721,
},
            new Int16Int160M
{
    Id = 125,
    Value = 29706,
    ModelInner = new Int16Int160MI
{
    Id = 133,
    Value = 14337,
    NullableValue = 19568,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 133,
    Value = 15566,
    ModelInner = new Int16Int160MI
{
    Id = 135,
    Value = 8867,
    NullableValue = 29283,
},
    NullableValue = 2508,
},
            new Int16Int160M
{
    Id = 142,
    Value = 2658,
    ModelInner = new Int16Int160MI
{
    Id = 141,
    Value = 16994,
    NullableValue = 7502,
},
    NullableValue = 19159,
},
            new Int16Int160M
{
    Id = 145,
    Value = 3679,
    ModelInner = new Int16Int160MI
{
    Id = 145,
    Value = 16171,
    NullableValue = 30735,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 149,
    Value = 2349,
    ModelInner = new Int16Int160MI
{
    Id = 150,
    Value = 10298,
    NullableValue = 8629,
},
    NullableValue = 1135,
},
            new Int16Int160M
{
    Id = 154,
    Value = 15794,
    ModelInner = new Int16Int160MI
{
    Id = 157,
    Value = 2420,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 161,
    Value = 296,
    ModelInner = new Int16Int160MI
{
    Id = 159,
    Value = 19565,
    NullableValue = 3774,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 162,
    Value = 215,
    ModelInner = new Int16Int160MI
{
    Id = 164,
    Value = 32021,
    NullableValue = 2762,
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
INSERT INTO gedaqtests.int16int160m(
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
FROM gedaqtests.int16int160m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int16Int160M)],
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
                    Int16Int160M.AssertModel(models[0],_testData[i], false);
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
                    Int16Int160M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

