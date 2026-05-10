

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
    Id = 1,
    Value = 7298,
    ModelInner = new Int16Int160MI
{
    Id = 3,
    Value = 24265,
    NullableValue = 14725,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 4,
    Value = 30414,
    ModelInner = new Int16Int160MI
{
    Id = 10,
    Value = 31521,
    NullableValue = 7452,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 13,
    Value = 9136,
    ModelInner = new Int16Int160MI
{
    Id = 19,
    Value = 31504,
    NullableValue = 22524,
},
    NullableValue = 10870,
},
            new Int16Int160M
{
    Id = 17,
    Value = 7326,
    ModelInner = new Int16Int160MI
{
    Id = 20,
    Value = 9737,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 20,
    Value = 11821,
    ModelInner = new Int16Int160MI
{
    Id = 28,
    Value = 22329,
    NullableValue = 31348,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 21,
    Value = 14187,
    ModelInner = new Int16Int160MI
{
    Id = 36,
    Value = 24125,
    NullableValue = 28494,
},
    NullableValue = 26962,
},
            new Int16Int160M
{
    Id = 28,
    Value = 14539,
    ModelInner = new Int16Int160MI
{
    Id = 45,
    Value = 19896,
    NullableValue = null,
},
    NullableValue = 23109,
},
            new Int16Int160M
{
    Id = 30,
    Value = 23407,
    ModelInner = new Int16Int160MI
{
    Id = 52,
    Value = 18671,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 36,
    Value = 26546,
    ModelInner = new Int16Int160MI
{
    Id = 61,
    Value = 7606,
    NullableValue = null,
},
    NullableValue = 28329,
},
            new Int16Int160M
{
    Id = 45,
    Value = 1328,
    ModelInner = new Int16Int160MI
{
    Id = 66,
    Value = 18292,
    NullableValue = 10514,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 49,
    Value = 7270,
    ModelInner = new Int16Int160MI
{
    Id = 67,
    Value = 29163,
    NullableValue = 16886,
},
    NullableValue = 10050,
},
            new Int16Int160M
{
    Id = 54,
    Value = 112,
    ModelInner = new Int16Int160MI
{
    Id = 76,
    Value = 4492,
    NullableValue = 8297,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 55,
    Value = 7972,
    ModelInner = new Int16Int160MI
{
    Id = 85,
    Value = 4526,
    NullableValue = 710,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 60,
    Value = 18022,
    ModelInner = new Int16Int160MI
{
    Id = 89,
    Value = 9761,
    NullableValue = 7325,
},
    NullableValue = 20851,
},
            new Int16Int160M
{
    Id = 61,
    Value = 11905,
    ModelInner = new Int16Int160MI
{
    Id = 91,
    Value = 29928,
    NullableValue = 5344,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 68,
    Value = 2974,
    ModelInner = new Int16Int160MI
{
    Id = 97,
    Value = 31011,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 76,
    Value = 14931,
    ModelInner = new Int16Int160MI
{
    Id = 106,
    Value = 19220,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 79,
    Value = 3523,
    ModelInner = new Int16Int160MI
{
    Id = 109,
    Value = 17918,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 87,
    Value = 31850,
    ModelInner = new Int16Int160MI
{
    Id = 113,
    Value = 24092,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 90,
    Value = 22666,
    ModelInner = new Int16Int160MI
{
    Id = 120,
    Value = 24273,
    NullableValue = 28868,
},
    NullableValue = 29137,
},
            new Int16Int160M
{
    Id = 99,
    Value = 17901,
    ModelInner = new Int16Int160MI
{
    Id = 125,
    Value = 22992,
    NullableValue = 4358,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 104,
    Value = 9362,
    ModelInner = new Int16Int160MI
{
    Id = 127,
    Value = 8197,
    NullableValue = 16064,
},
    NullableValue = 21503,
},
            new Int16Int160M
{
    Id = 105,
    Value = 13311,
    ModelInner = new Int16Int160MI
{
    Id = 132,
    Value = 10153,
    NullableValue = null,
},
    NullableValue = 9664,
},
            new Int16Int160M
{
    Id = 109,
    Value = 23471,
    ModelInner = new Int16Int160MI
{
    Id = 141,
    Value = 14617,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 111,
    Value = 29055,
    ModelInner = new Int16Int160MI
{
    Id = 149,
    Value = 20239,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 115,
    Value = 22950,
    ModelInner = new Int16Int160MI
{
    Id = 154,
    Value = 13700,
    NullableValue = null,
},
    NullableValue = 26212,
},
            new Int16Int160M
{
    Id = 122,
    Value = 7184,
    ModelInner = new Int16Int160MI
{
    Id = 159,
    Value = 3909,
    NullableValue = null,
},
    NullableValue = 15277,
},
            new Int16Int160M
{
    Id = 127,
    Value = 5739,
    ModelInner = new Int16Int160MI
{
    Id = 168,
    Value = 27540,
    NullableValue = 30278,
},
    NullableValue = 9406,
},
            new Int16Int160M
{
    Id = 130,
    Value = 3101,
    ModelInner = new Int16Int160MI
{
    Id = 173,
    Value = 9326,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 133,
    Value = 21017,
    ModelInner = new Int16Int160MI
{
    Id = 178,
    Value = 6653,
    NullableValue = null,
},
    NullableValue = 28145,
},
            new Int16Int160M
{
    Id = 134,
    Value = 9236,
    ModelInner = new Int16Int160MI
{
    Id = 182,
    Value = 31696,
    NullableValue = 18434,
},
    NullableValue = 9801,
},
            new Int16Int160M
{
    Id = 136,
    Value = 8963,
    ModelInner = new Int16Int160MI
{
    Id = 185,
    Value = 11203,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 138,
    Value = 32436,
    ModelInner = new Int16Int160MI
{
    Id = 190,
    Value = 31567,
    NullableValue = 20276,
},
    NullableValue = 31042,
},
            new Int16Int160M
{
    Id = 141,
    Value = 25079,
    ModelInner = new Int16Int160MI
{
    Id = 198,
    Value = 14787,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int160M
{
    Id = 147,
    Value = 14624,
    ModelInner = new Int16Int160MI
{
    Id = 202,
    Value = 1291,
    NullableValue = 32018,
},
    NullableValue = 9965,
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

