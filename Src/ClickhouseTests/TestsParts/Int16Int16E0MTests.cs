

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
    Id = 7,
    Value = 5385,
    ModelInner = new Int16Int160MI
{
    Id = 3,
    Value = 7039,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 12,
    Value = 19304,
    ModelInner = new Int16Int160MI
{
    Id = 6,
    Value = 5818,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 18,
    Value = 9648,
    ModelInner = new Int16Int160MI
{
    Id = 8,
    Value = 29702,
    NullableValue = 29599,
},
    NullableValue = 14826,
},
            new Int16Int16E0M
{
    Id = 19,
    Value = 26776,
    ModelInner = new Int16Int160MI
{
    Id = 16,
    Value = 12112,
    NullableValue = null,
},
    NullableValue = 1687,
},
            new Int16Int16E0M
{
    Id = 22,
    Value = 28946,
    ModelInner = new Int16Int160MI
{
    Id = 23,
    Value = 25789,
    NullableValue = null,
},
    NullableValue = 26963,
},
            new Int16Int16E0M
{
    Id = 27,
    Value = 15213,
    ModelInner = new Int16Int160MI
{
    Id = 24,
    Value = 16662,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 33,
    Value = 2725,
    ModelInner = new Int16Int160MI
{
    Id = 29,
    Value = 28849,
    NullableValue = 8190,
},
    NullableValue = 7913,
},
            new Int16Int16E0M
{
    Id = 36,
    Value = 315,
    ModelInner = new Int16Int160MI
{
    Id = 33,
    Value = 24129,
    NullableValue = null,
},
    NullableValue = 30620,
},
            new Int16Int16E0M
{
    Id = 41,
    Value = 11121,
    ModelInner = new Int16Int160MI
{
    Id = 39,
    Value = 3398,
    NullableValue = 8290,
},
    NullableValue = 28471,
},
            new Int16Int16E0M
{
    Id = 50,
    Value = 31392,
    ModelInner = new Int16Int160MI
{
    Id = 46,
    Value = 7164,
    NullableValue = 13841,
},
    NullableValue = 24063,
},
            new Int16Int16E0M
{
    Id = 55,
    Value = 28157,
    ModelInner = new Int16Int160MI
{
    Id = 54,
    Value = 10558,
    NullableValue = null,
},
    NullableValue = 23822,
},
            new Int16Int16E0M
{
    Id = 56,
    Value = 15474,
    ModelInner = new Int16Int160MI
{
    Id = 55,
    Value = 8018,
    NullableValue = 14813,
},
    NullableValue = 19798,
},
            new Int16Int16E0M
{
    Id = 60,
    Value = 16579,
    ModelInner = new Int16Int160MI
{
    Id = 56,
    Value = 1173,
    NullableValue = 9410,
},
    NullableValue = 9629,
},
            new Int16Int16E0M
{
    Id = 68,
    Value = 12098,
    ModelInner = new Int16Int160MI
{
    Id = 63,
    Value = 31539,
    NullableValue = null,
},
    NullableValue = 28548,
},
            new Int16Int16E0M
{
    Id = 76,
    Value = 16329,
    ModelInner = new Int16Int160MI
{
    Id = 71,
    Value = 28570,
    NullableValue = null,
},
    NullableValue = 16773,
},
            new Int16Int16E0M
{
    Id = 82,
    Value = 2344,
    ModelInner = new Int16Int160MI
{
    Id = 73,
    Value = 10159,
    NullableValue = 9624,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 85,
    Value = 19381,
    ModelInner = new Int16Int160MI
{
    Id = 74,
    Value = 26740,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 86,
    Value = 24433,
    ModelInner = new Int16Int160MI
{
    Id = 77,
    Value = 22032,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 87,
    Value = 14761,
    ModelInner = new Int16Int160MI
{
    Id = 86,
    Value = 25258,
    NullableValue = 20249,
},
    NullableValue = 21510,
},
            new Int16Int16E0M
{
    Id = 92,
    Value = 8471,
    ModelInner = new Int16Int160MI
{
    Id = 89,
    Value = 14001,
    NullableValue = 24614,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 93,
    Value = 20776,
    ModelInner = new Int16Int160MI
{
    Id = 90,
    Value = 20315,
    NullableValue = null,
},
    NullableValue = 14766,
},
            new Int16Int16E0M
{
    Id = 99,
    Value = 6097,
    ModelInner = new Int16Int160MI
{
    Id = 92,
    Value = 22837,
    NullableValue = 16832,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 100,
    Value = 4867,
    ModelInner = new Int16Int160MI
{
    Id = 95,
    Value = 31263,
    NullableValue = 12309,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 102,
    Value = 5226,
    ModelInner = new Int16Int160MI
{
    Id = 101,
    Value = 20681,
    NullableValue = null,
},
    NullableValue = 1807,
},
            new Int16Int16E0M
{
    Id = 111,
    Value = 28068,
    ModelInner = new Int16Int160MI
{
    Id = 110,
    Value = 15797,
    NullableValue = null,
},
    NullableValue = 11166,
},
            new Int16Int16E0M
{
    Id = 120,
    Value = 20406,
    ModelInner = new Int16Int160MI
{
    Id = 116,
    Value = 31607,
    NullableValue = 24196,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 129,
    Value = 10278,
    ModelInner = new Int16Int160MI
{
    Id = 124,
    Value = 21614,
    NullableValue = 24757,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 134,
    Value = 29097,
    ModelInner = new Int16Int160MI
{
    Id = 130,
    Value = 18476,
    NullableValue = 13566,
},
    NullableValue = 1004,
},
            new Int16Int16E0M
{
    Id = 140,
    Value = 9027,
    ModelInner = new Int16Int160MI
{
    Id = 138,
    Value = 2092,
    NullableValue = 1256,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 146,
    Value = 11639,
    ModelInner = new Int16Int160MI
{
    Id = 147,
    Value = 9398,
    NullableValue = null,
},
    NullableValue = 742,
},
            new Int16Int16E0M
{
    Id = 148,
    Value = 17634,
    ModelInner = new Int16Int160MI
{
    Id = 150,
    Value = 10516,
    NullableValue = null,
},
    NullableValue = 23594,
},
            new Int16Int16E0M
{
    Id = 156,
    Value = 5298,
    ModelInner = new Int16Int160MI
{
    Id = 154,
    Value = 27575,
    NullableValue = 13405,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 158,
    Value = 2222,
    ModelInner = new Int16Int160MI
{
    Id = 155,
    Value = 6088,
    NullableValue = 16725,
},
    NullableValue = 32656,
},
            new Int16Int16E0M
{
    Id = 165,
    Value = 18437,
    ModelInner = new Int16Int160MI
{
    Id = 160,
    Value = 24810,
    NullableValue = 10079,
},
    NullableValue = 13115,
},
            new Int16Int16E0M
{
    Id = 168,
    Value = 916,
    ModelInner = new Int16Int160MI
{
    Id = 163,
    Value = 4691,
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

